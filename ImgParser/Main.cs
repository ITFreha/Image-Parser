using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgParser
{
    public partial class Main : Form
    {
        private CancellationTokenSource cts1;
        private CancellationTokenSource cts2;
        private CancellationTokenSource cts3;

        public Main()
        {
            InitializeComponent();

            /*
            if (NativeMethods.AllocConsole())
            {
                IntPtr stdHandle = NativeMethods.GetStdHandle(NativeMethods.STD_OUTPUT_HANDLE);
            }//*/

            stoptask1button.Enabled = false;
            stoptask2button.Enabled = false;
            stoptask3button.Enabled = false;
        }

        private void parsingbutton_Click(object sender, EventArgs e)
        {
            string address = textBox1.Text;
            int depth = (int)numericUpDown1.Value;

            if (address.Length > 0 && address[address.Length - 1] != '/')
                address = address + "/";

            if (!stoptask1button.Enabled)
            {
                cts1 = new CancellationTokenSource();

                Task.Factory.StartNew(() => StartQueue(address, depth, cts1, task1text, progressBar1, stoptask1button));
                stoptask1button.Enabled = true;
            }
            else if (!stoptask2button.Enabled)
            {
                cts2 = new CancellationTokenSource();

                Task.Factory.StartNew(() => StartQueue(address, depth, cts2, task2text, progressBar2, stoptask2button));
                stoptask2button.Enabled = true;
            }
            else if (!stoptask3button.Enabled)
            {
                cts3 = new CancellationTokenSource();

                Task.Factory.StartNew(() => StartQueue(address, depth, cts3, task3text, progressBar3, stoptask3button));
                stoptask3button.Enabled = true;
            }

            if (stoptask1button.Enabled && stoptask2button.Enabled && stoptask3button.Enabled)
            {
                parsingbutton.Enabled = false;
            }
        }

        private void stoptask1button_Click(object sender, EventArgs e)
        {
            Cancel(cts1, task1text, stoptask1button);
        }

        private void stoptask2button_Click(object sender, EventArgs e)
        {
            Cancel(cts2, task2text, stoptask2button);
        }

        private void stoptask3button_Click(object sender, EventArgs e)
        {
            Cancel(cts3, task3text, stoptask3button);
        }

        private void opendirbutton_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            Process.Start(dir);
        }

        private void Cancel(CancellationTokenSource cts, TextBox tasktext, Button stoptaskbutton)
        {
            cts.Cancel();
            tasktext.Text = "aborted";
            stoptaskbutton.Enabled = false;

            parsingbutton.Enabled = true;
        }

        public struct Element
        {
            public int d;
            public string link;

            public Element(string link_on_page, int depth)
            {
                link = link_on_page;
                d = depth;
            }
        }

        public void StartQueue(string address, int depth, 
            CancellationTokenSource cts, TextBox tasktext, ProgressBar progress, Button stoptaskbutton)
        {
            tasktext.Text = address;

            if (OpenPage(address) == null)
            {
                Cancel(cts, tasktext, stoptaskbutton);
                progress.Value = progress.Minimum;
                tasktext.Text = "Open error";
                return;
            }

            Task.Factory.StartNew(() => {
                progress.Minimum = 0;
                progress.Maximum = 10000;

                while (true)
                {
                    progress.Value = 0;
                    for (int i = 0; i < 10300; i++)
                    {
                        progress.Increment(1);
                        Thread.Sleep(1);

                        cts.Token.ThrowIfCancellationRequested();
                    }
                }
            }, cts.Token);

            HashSet<string> set = new HashSet<string>();
            Queue<Element> queue = new Queue<Element>();
            queue.Enqueue(new Element(address, 0));

            Element t;
            while (queue.Count != 0)
            {
                t = queue.Dequeue();

                if (t.d > depth)
                    break;

                //Console.WriteLine("_____________________" + t.d + "_____________________");

                string ans = OpenPage(t.link);
                if (ans == null)
                    continue;

                List<string> pictsLinks = ParseLinksOnPictures(ans);
                ParseLinksOnPages(address, ans, queue, t.d, set);

                string path = RemoveBannedSymbols(t.link, true) + "/";
                string supposedMainAdress = PickOutMainAddress(t.link);
                DownloadPictures(supposedMainAdress, address, path, pictsLinks, cts);

                if (cts.IsCancellationRequested)
                    return;
            }

            cts.Cancel();
            stoptaskbutton.Enabled = false;
            tasktext.Text = "completed";
            progress.Value = progressBar1.Maximum;

            parsingbutton.Enabled = true;
        }

        string PickOutMainAddress(string address)
        {
            int pos = 8;
            while (address[pos] != '/')
                pos++;

            return address.Substring(0, pos + 1);
        }

        public void DownloadPictures(string supposedMainAdress, string address, string path,
            List<string> links, CancellationTokenSource cts)
        {
            if (checkBox1.Checked)
                path = RemoveBannedSymbols(address, true) + "/";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            WebClient wcl = new WebClient();
            
            foreach (var link in links)
            {
                if (cts.IsCancellationRequested)
                    return;

                string name = RemoveBannedSymbols(link, false);

                //Console.WriteLine(link);

                try { wcl.DownloadFile(link, path + name + ".jpg"); }
                catch { }
                try { wcl.DownloadFile(address + '/' + link, path + name + "2.jpg"); }
                catch { }
                try { wcl.DownloadFile("http:" + link, path + name + "3.jpg"); }
                catch { }
                try { wcl.DownloadFile("http://" + link, path + name + "4.jpg"); }
                catch { }
                try { wcl.DownloadFile(supposedMainAdress + link, path + name + "5.jpg"); }
                catch { }
            }

            wcl.Dispose();
        }

        public string OpenPage(string address)
        {
            string ans;

            try
            {
                WebClient wcl = new WebClient();

                ans = Encoding.UTF8.GetString(wcl.DownloadData(address));
                //Console.WriteLine(ans);

                wcl.Dispose();
            }
            catch { ans = null; }

            return ans;
        }

        public string RemoveBannedSymbols(string s, bool forDir)
        {
            char[] chs = "\\/:*?\"<>|".ToCharArray();

            foreach (char ch in chs)
            {
                s = s.Replace(ch.ToString(), "");
            }

            if (!forDir)
                s = s.Remove(s.Length / 4, s.Length / 2);

            return s;
        }

        public List<string> ParseLinksOnPictures(string ans)
        {
            List<string> list = new List<string>();

            int pos = 0;
            while ((pos = ans.IndexOf("<img", pos)) != -1)
                while (ans[pos] != '>')
                {
                    if (ans[pos] == 's' && ans[pos + 1] == 'r' && ans[pos + 2] == 'c' && ans[pos + 3] == '=' && ans[pos + 4] == '"')
                    {
                        StringBuilder sb = new StringBuilder(100);

                        pos += 5;
                        while (ans[pos] != '"')
                        {
                            sb.Append(ans[pos], 1);
                            pos++;
                        }

                        list.Add(sb.ToString());
                    }

                    pos++;
                }

            return list;
        }

        public void ParseLinksOnPages(string address, string ans, Queue<Element> queue, int depth, HashSet<string> set)
        {
            int pos = 0;
            while ((pos = ans.IndexOf("<a", pos)) != -1)
                while (ans[pos] != '>')
                {
                    if (ans[pos] == 'h' && ans[pos + 1] == 'r' && ans[pos + 2] == 'e' && ans[pos + 3] == 'f' && ans[pos + 4] == '=' && ans[pos + 5] == '"')
                    {
                        StringBuilder sb = new StringBuilder(100);

                        pos += 6;
                        while (ans[pos] != '"')
                        {
                            sb.Append(ans[pos], 1);
                            pos++;
                        }

                        string link = sb.ToString();

                        if (!set.Contains(link))
                        {
                            set.Add(link);

                            queue.Enqueue(new Element(
                                link,
                                depth + 1
                            ));

                            queue.Enqueue(new Element(
                                address + "/" + link,
                                depth + 1
                            ));
                        }
                    }

                    pos++;
                }
        }

        public class NativeMethods
        {
            public static Int32 STD_OUTPUT_HANDLE;

            [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "GetStdHandle")]
            public static extern IntPtr GetStdHandle(Int32 nStdHandle);

            [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "AllocConsole")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool AllocConsole();
        }
    }
}