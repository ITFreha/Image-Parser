using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ImgParser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Last parsing"))
                Directory.Delete("Last parsing", true);
            Directory.CreateDirectory("Last parsing");

            string address = textBox1.Text;
            int depth = (int)numericUpDown1.Value;

            if (NativeMethods.AllocConsole())
            {
                IntPtr stdHandle = NativeMethods.GetStdHandle(NativeMethods.STD_OUTPUT_HANDLE);
            }

            DonwloadPictures("Last parsing/", address);
        }

        public void DonwloadPictures(string to, string address)
        {
            WebClient wcl = new WebClient();
            
            foreach (var el in ParseLinksOnPictures(OpenPage(address)))
            {
                string s = RemoveBannedSymbols(el);

                Console.WriteLine(s);

                try { wcl.DownloadFile(el, "Last parsing/" + s + ".jpg"); }
                catch { }
                try { wcl.DownloadFile(address + '/' + el, "Last parsing/" + s + "2.jpg"); }
                catch { }
            }

            wcl.Dispose();
        }

        public string OpenPage(string address)
        {
            WebClient wcl = new WebClient();

            string ans = Encoding.UTF8.GetString(wcl.DownloadData(address));
            Console.WriteLine(ans);

            wcl.Dispose();

            return ans;
        }

        public string RemoveBannedSymbols(string s)
        {
            char[] chs = "\\/:*?\"<>|".ToCharArray();

            foreach (char ch in chs)
            {
                s = s.Replace(ch.ToString(), "");
            }

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
