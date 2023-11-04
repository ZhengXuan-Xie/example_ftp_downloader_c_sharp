namespace Bills_Manager
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            package_name = new TextBox();
            ftp_path = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(71, 255);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "下载并更新";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 340);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(525, 74);
            textBox1.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(69, 153);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(696, 34);
            progressBar1.TabIndex = 2;
            // 
            // package_name
            // 
            package_name.Location = new Point(108, 37);
            package_name.Name = "package_name";
            package_name.Size = new Size(280, 30);
            package_name.TabIndex = 3;
            // 
            // ftp_path
            // 
            ftp_path.Location = new Point(108, 92);
            ftp_path.Name = "ftp_path";
            ftp_path.Size = new Size(280, 30);
            ftp_path.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 5;
            label1.Text = "文件名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 100);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 6;
            label2.Text = "ftp地址";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ftp_path);
            Controls.Add(package_name);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "MainPage";
            Text = "FTP更新例程";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private TextBox package_name;
        private TextBox ftp_path;
        private Label label1;
        private Label label2;
    }
}