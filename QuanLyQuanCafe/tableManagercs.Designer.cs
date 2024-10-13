namespace QuanLyQuanCAFE
{
    partial class tableManagercs
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem1 = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lvBill = new ListView();
            panel3 = new Panel();
            cbSwitchTable = new ComboBox();
            SwitchTable = new Button();
            numericUpDown = new NumericUpDown();
            butDiscount = new Button();
            Pay = new Button();
            panel4 = new Panel();
            nnFoodCount = new NumericUpDown();
            AddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nnFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(897, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinCáNhânToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(897, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem1, đăngXuấtToolStripMenuItem });
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(141, 24);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            thôngTinCáNhânToolStripMenuItem1.Size = new Size(224, 26);
            thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lvBill);
            panel2.Location = new Point(466, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 340);
            panel2.TabIndex = 3;
            // 
            // lvBill
            // 
            lvBill.Location = new Point(0, 3);
            lvBill.Name = "lvBill";
            lvBill.Size = new Size(422, 334);
            lvBill.TabIndex = 0;
            lvBill.UseCompatibleStateImageBehavior = false;
            lvBill.SelectedIndexChanged += lvBill_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(SwitchTable);
            panel3.Controls.Add(numericUpDown);
            panel3.Controls.Add(butDiscount);
            panel3.Controls.Add(Pay);
            panel3.Location = new Point(466, 506);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 70);
            panel3.TabIndex = 4;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(0, 31);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(114, 28);
            cbSwitchTable.TabIndex = 7;
            // 
            // SwitchTable
            // 
            SwitchTable.Location = new Point(-1, 0);
            SwitchTable.Name = "SwitchTable";
            SwitchTable.Size = new Size(115, 31);
            SwitchTable.TabIndex = 6;
            SwitchTable.Text = "Chuyển Bàn";
            SwitchTable.UseVisualStyleBackColor = true;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(204, 32);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(104, 27);
            numericUpDown.TabIndex = 5;
            numericUpDown.TextAlign = HorizontalAlignment.Center;
            numericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // butDiscount
            // 
            butDiscount.Location = new Point(204, 4);
            butDiscount.Name = "butDiscount";
            butDiscount.Size = new Size(105, 27);
            butDiscount.TabIndex = 4;
            butDiscount.Text = "Giảm giá";
            butDiscount.UseVisualStyleBackColor = true;
            // 
            // Pay
            // 
            Pay.Location = new Point(307, 3);
            Pay.Name = "Pay";
            Pay.Size = new Size(109, 64);
            Pay.TabIndex = 3;
            Pay.Text = "Thanh Toán";
            Pay.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(nnFoodCount);
            panel4.Controls.Add(AddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(466, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(419, 89);
            panel4.TabIndex = 5;
            // 
            // nnFoodCount
            // 
            nnFoodCount.Location = new Point(347, 34);
            nnFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nnFoodCount.Name = "nnFoodCount";
            nnFoodCount.Size = new Size(52, 27);
            nnFoodCount.TabIndex = 3;
            nnFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddFood
            // 
            AddFood.Location = new Point(232, 18);
            AddFood.Name = "AddFood";
            AddFood.Size = new Size(109, 43);
            AddFood.TabIndex = 2;
            AddFood.Text = "Thêm Món";
            AddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 47);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(205, 28);
            cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(205, 28);
            cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(12, 71);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(414, 481);
            flpTable.TabIndex = 6;
            // 
            // tableManagercs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 650);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "tableManagercs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý quán cafe";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nnFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lvBill;
        private Panel panel3;
        private Panel panel4;
        private ComboBox cbCategory;
        private NumericUpDown nnFoodCount;
        private Button AddFood;
        private ComboBox cbFood;
        private FlowLayoutPanel flpTable;
        private Button Pay;
        private NumericUpDown numericUpDown;
        private Button butDiscount;
        private ComboBox cbSwitchTable;
        private Button SwitchTable;
    }
}