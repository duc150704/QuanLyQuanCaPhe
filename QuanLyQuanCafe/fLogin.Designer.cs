

namespace QuanLyQuanCAFE
{
    partial class fLogin
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            butExit = new Button();
            butLogin = new Button();
            panel3 = new Panel();
            lbPassWord = new Label();
            texPassWord = new TextBox();
            panel2 = new Panel();
            lbUserName = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "admin";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(butExit);
            panel1.Controls.Add(butLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(29, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 231);
            panel1.TabIndex = 1;
            // 
            // butExit
            // 
            butExit.Location = new Point(417, 170);
            butExit.Name = "butExit";
            butExit.Size = new Size(94, 29);
            butExit.TabIndex = 5;
            butExit.Text = "Thoát";
            butExit.UseVisualStyleBackColor = true;
            butExit.Click += butExit_Click;
            // 
            // butLogin
            // 
            butLogin.Location = new Point(233, 170);
            butLogin.Name = "butLogin";
            butLogin.Size = new Size(94, 29);
            butLogin.TabIndex = 4;
            butLogin.Text = "Đăng Nhập";
            butLogin.UseVisualStyleBackColor = true;
            butLogin.Click += ButLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbPassWord);
            panel3.Controls.Add(texPassWord);
            panel3.Location = new Point(3, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(577, 78);
            panel3.TabIndex = 3;
            // 
            // lbPassWord
            // 
            lbPassWord.AutoSize = true;
            lbPassWord.Location = new Point(37, 28);
            lbPassWord.Name = "lbPassWord";
            lbPassWord.Size = new Size(72, 20);
            lbPassWord.TabIndex = 1;
            lbPassWord.Text = "Mật Khẩu";
            // 
            // texPassWord
            // 
            texPassWord.Location = new Point(179, 25);
            texPassWord.Name = "texPassWord";
            texPassWord.Size = new Size(386, 27);
            texPassWord.TabIndex = 0;
            texPassWord.Text = "admin";
            texPassWord.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbUserName);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 63);
            panel2.TabIndex = 2;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(37, 23);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(112, 20);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "Tên Đăng Nhập";
            lbUserName.FontChanged += lbUserName_FontChanged;
            // 
            // fLogin
            // 
            AcceptButton = butLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = butExit;
            ClientSize = new Size(650, 282);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void lbUserName_FontChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private Label lbUserName;
        private Panel panel3;
        private Label lbPassWord;
        private TextBox texPassWord;
        private Button butExit;
        private Button butLogin;
    }
}
