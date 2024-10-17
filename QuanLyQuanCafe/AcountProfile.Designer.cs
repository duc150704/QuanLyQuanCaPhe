namespace QuanLyQuanCAFE
{
    partial class AcountProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            lbUserName = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            txbDisPlayName = new TextBox();
            panel4 = new Panel();
            lbPassWord = new Label();
            texPassWord = new TextBox();
            panel5 = new Panel();
            label2 = new Label();
            textBox3 = new TextBox();
            panel6 = new Panel();
            label3 = new Label();
            textBox2 = new TextBox();
            butUpdate = new Button();
            butExit = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lbUserName);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 63);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(9, 22);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(163, 24);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "Tên Đăng Nhập:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(179, 20);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(386, 27);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txbDisPlayName);
            panel3.Location = new Point(3, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(577, 63);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 1;
            label1.Text = "Tên Hiển Thị :";
            // 
            // txbDisPlayName
            // 
            txbDisPlayName.BackColor = SystemColors.ButtonHighlight;
            txbDisPlayName.Location = new Point(179, 20);
            txbDisPlayName.Name = "txbDisPlayName";
            txbDisPlayName.ReadOnly = true;
            txbDisPlayName.Size = new Size(386, 27);
            txbDisPlayName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbPassWord);
            panel4.Controls.Add(texPassWord);
            panel4.Location = new Point(3, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(577, 78);
            panel4.TabIndex = 5;
            // 
            // lbPassWord
            // 
            lbPassWord.AutoSize = true;
            lbPassWord.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassWord.Location = new Point(15, 25);
            lbPassWord.Name = "lbPassWord";
            lbPassWord.Size = new Size(107, 24);
            lbPassWord.TabIndex = 1;
            lbPassWord.Text = "Mật Khẩu:";
            // 
            // texPassWord
            // 
            texPassWord.Location = new Point(179, 25);
            texPassWord.Name = "texPassWord";
            texPassWord.Size = new Size(386, 27);
            texPassWord.TabIndex = 0;
            texPassWord.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textBox3);
            panel5.Location = new Point(3, 309);
            panel5.Name = "panel5";
            panel5.Size = new Size(577, 78);
            panel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 28);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 1;
            label2.Text = "Nhập Lại:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(386, 27);
            textBox3.TabIndex = 0;
            textBox3.UseSystemPasswordChar = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Controls.Add(textBox2);
            panel6.Location = new Point(0, 225);
            panel6.Name = "panel6";
            panel6.Size = new Size(577, 78);
            panel6.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 28);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 1;
            label3.Text = "Mật Khẩu Mới:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(386, 27);
            textBox2.TabIndex = 0;
            textBox2.UseSystemPasswordChar = true;
            // 
            // butUpdate
            // 
            butUpdate.Location = new Point(138, 407);
            butUpdate.Name = "butUpdate";
            butUpdate.Size = new Size(177, 31);
            butUpdate.TabIndex = 7;
            butUpdate.Text = "Cập Nhật";
            butUpdate.UseVisualStyleBackColor = true;
            butUpdate.Click += butUpdate_Click;
            // 
            // butExit
            // 
            butExit.Location = new Point(345, 407);
            butExit.Name = "butExit";
            butExit.Size = new Size(177, 31);
            butExit.TabIndex = 8;
            butExit.Text = "Thoát";
            butExit.UseVisualStyleBackColor = true;
            butExit.Click += butExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(butExit);
            panel1.Controls.Add(butUpdate);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(20, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 450);
            panel1.TabIndex = 0;
            // 
            // AcountProfile
            // 
            AcceptButton = butUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = butExit;
            ClientSize = new Size(631, 488);
            Controls.Add(panel1);
            Name = "AcountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lbUserName;
        private TextBox textBox1;
        private Panel panel3;
        private Label label1;
        private TextBox txbDisPlayName;
        private Panel panel4;
        private Label lbPassWord;
        private TextBox texPassWord;
        private Panel panel5;
        private Label label2;
        private TextBox textBox3;
        private Panel panel6;
        private Label label3;
        private TextBox textBox2;
        private Button butUpdate;
        private Button butExit;
        private Panel panel1;
    }
}