namespace ImgParser
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parsingbutton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.task1label = new System.Windows.Forms.Label();
            this.task1text = new System.Windows.Forms.TextBox();
            this.stoptask1button = new System.Windows.Forms.Button();
            this.stoptask2button = new System.Windows.Forms.Button();
            this.task2text = new System.Windows.Forms.TextBox();
            this.task2label = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.stoptask3button = new System.Windows.Forms.Button();
            this.task3text = new System.Windows.Forms.TextBox();
            this.task3label = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.opendirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "https://youtube.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input website";
            // 
            // parsingbutton
            // 
            this.parsingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parsingbutton.Location = new System.Drawing.Point(371, 92);
            this.parsingbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.parsingbutton.Name = "parsingbutton";
            this.parsingbutton.Size = new System.Drawing.Size(110, 60);
            this.parsingbutton.TabIndex = 2;
            this.parsingbutton.Text = "do parse";
            this.parsingbutton.UseVisualStyleBackColor = true;
            this.parsingbutton.Click += new System.EventHandler(this.parsingbutton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(69, 121);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(63, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "depth";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(185, 96);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "in one folder";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(64, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // task1label
            // 
            this.task1label.AutoSize = true;
            this.task1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1label.Location = new System.Drawing.Point(9, 168);
            this.task1label.Name = "task1label";
            this.task1label.Size = new System.Drawing.Size(49, 20);
            this.task1label.TabIndex = 7;
            this.task1label.Text = "task1";
            // 
            // task1text
            // 
            this.task1text.Location = new System.Drawing.Point(266, 170);
            this.task1text.Name = "task1text";
            this.task1text.ReadOnly = true;
            this.task1text.Size = new System.Drawing.Size(112, 20);
            this.task1text.TabIndex = 8;
            this.task1text.Text = "empty";
            // 
            // stoptask1button
            // 
            this.stoptask1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoptask1button.Location = new System.Drawing.Point(406, 168);
            this.stoptask1button.Name = "stoptask1button";
            this.stoptask1button.Size = new System.Drawing.Size(75, 23);
            this.stoptask1button.TabIndex = 9;
            this.stoptask1button.Text = "stop";
            this.stoptask1button.UseVisualStyleBackColor = true;
            this.stoptask1button.Click += new System.EventHandler(this.stoptask1button_Click);
            // 
            // stoptask2button
            // 
            this.stoptask2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoptask2button.Location = new System.Drawing.Point(406, 197);
            this.stoptask2button.Name = "stoptask2button";
            this.stoptask2button.Size = new System.Drawing.Size(75, 23);
            this.stoptask2button.TabIndex = 13;
            this.stoptask2button.Text = "stop";
            this.stoptask2button.UseVisualStyleBackColor = true;
            this.stoptask2button.Click += new System.EventHandler(this.stoptask2button_Click);
            // 
            // task2text
            // 
            this.task2text.Location = new System.Drawing.Point(266, 199);
            this.task2text.Name = "task2text";
            this.task2text.ReadOnly = true;
            this.task2text.Size = new System.Drawing.Size(112, 20);
            this.task2text.TabIndex = 12;
            this.task2text.Text = "empty";
            // 
            // task2label
            // 
            this.task2label.AutoSize = true;
            this.task2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task2label.Location = new System.Drawing.Point(9, 197);
            this.task2label.Name = "task2label";
            this.task2label.Size = new System.Drawing.Size(49, 20);
            this.task2label.TabIndex = 11;
            this.task2label.Text = "task2";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(64, 197);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(196, 23);
            this.progressBar2.TabIndex = 10;
            // 
            // stoptask3button
            // 
            this.stoptask3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoptask3button.Location = new System.Drawing.Point(406, 226);
            this.stoptask3button.Name = "stoptask3button";
            this.stoptask3button.Size = new System.Drawing.Size(75, 23);
            this.stoptask3button.TabIndex = 17;
            this.stoptask3button.Text = "stop";
            this.stoptask3button.UseVisualStyleBackColor = true;
            this.stoptask3button.Click += new System.EventHandler(this.stoptask3button_Click);
            // 
            // task3text
            // 
            this.task3text.Location = new System.Drawing.Point(266, 228);
            this.task3text.Name = "task3text";
            this.task3text.ReadOnly = true;
            this.task3text.Size = new System.Drawing.Size(112, 20);
            this.task3text.TabIndex = 16;
            this.task3text.Text = "empty";
            // 
            // task3label
            // 
            this.task3label.AutoSize = true;
            this.task3label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task3label.Location = new System.Drawing.Point(9, 226);
            this.task3label.Name = "task3label";
            this.task3label.Size = new System.Drawing.Size(49, 20);
            this.task3label.TabIndex = 15;
            this.task3label.Text = "task3";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(64, 226);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(196, 23);
            this.progressBar3.TabIndex = 14;
            // 
            // opendirbutton
            // 
            this.opendirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opendirbutton.Location = new System.Drawing.Point(12, 9);
            this.opendirbutton.Name = "opendirbutton";
            this.opendirbutton.Size = new System.Drawing.Size(75, 30);
            this.opendirbutton.TabIndex = 18;
            this.opendirbutton.Text = "open dir";
            this.opendirbutton.UseVisualStyleBackColor = true;
            this.opendirbutton.Click += new System.EventHandler(this.opendirbutton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 271);
            this.Controls.Add(this.opendirbutton);
            this.Controls.Add(this.stoptask3button);
            this.Controls.Add(this.task3text);
            this.Controls.Add(this.task3label);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.stoptask2button);
            this.Controls.Add(this.task2text);
            this.Controls.Add(this.task2label);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.stoptask1button);
            this.Controls.Add(this.task1text);
            this.Controls.Add(this.task1label);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.parsingbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Main";
            this.Opacity = 0.97D;
            this.Text = "Image parser";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button parsingbutton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label task1label;
        private System.Windows.Forms.TextBox task1text;
        private System.Windows.Forms.Button stoptask1button;
        private System.Windows.Forms.Button stoptask2button;
        private System.Windows.Forms.TextBox task2text;
        private System.Windows.Forms.Label task2label;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button stoptask3button;
        private System.Windows.Forms.TextBox task3text;
        private System.Windows.Forms.Label task3label;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button opendirbutton;
    }
}

