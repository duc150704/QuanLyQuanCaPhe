﻿namespace QuanLyQuanCAFE
{
    partial class TableManagerUI
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
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbtotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            SwitchTable = new Button();
            nmDiscount = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
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
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
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
            thôngTinCáNhânToolStripMenuItem1.Size = new Size(210, 26);
            thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem1.Click += thôngTinCáNhânToolStripMenuItem1_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(210, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(466, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 354);
            panel2.TabIndex = 3;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(416, 348);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            lsvBill.SelectedIndexChanged += lvBill_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số Lượng";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbtotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(SwitchTable);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(butDiscount);
            panel3.Controls.Add(Pay);
            panel3.Location = new Point(466, 506);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 70);
            panel3.TabIndex = 4;
            // 
            // txbtotalPrice
            // 
            txbtotalPrice.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbtotalPrice.Location = new Point(230, 34);
            txbtotalPrice.Name = "txbtotalPrice";
            txbtotalPrice.ReadOnly = true;
            txbtotalPrice.Size = new Size(186, 28);
            txbtotalPrice.TabIndex = 8;
            txbtotalPrice.Text = "0";
            txbtotalPrice.TextAlign = HorizontalAlignment.Center;
            txbtotalPrice.TextChanged += txbtotalPrice_TextChanged;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(0, 34);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(114, 28);
            cbSwitchTable.TabIndex = 7;
            cbSwitchTable.SelectedIndexChanged += cbSwitchTable_SelectedIndexChanged;
            // 
            // SwitchTable
            // 
            SwitchTable.Location = new Point(-1, 0);
            SwitchTable.Name = "SwitchTable";
            SwitchTable.Size = new Size(115, 31);
            SwitchTable.TabIndex = 6;
            SwitchTable.Text = "Chuyển Bàn";
            SwitchTable.UseVisualStyleBackColor = true;
            SwitchTable.Click += SwitchTable_Click;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(120, 35);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(104, 27);
            nmDiscount.TabIndex = 5;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            nmDiscount.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // butDiscount
            // 
            butDiscount.Location = new Point(120, 0);
            butDiscount.Name = "butDiscount";
            butDiscount.Size = new Size(105, 32);
            butDiscount.TabIndex = 4;
            butDiscount.Text = "Giảm giá";
            butDiscount.UseVisualStyleBackColor = true;
            // 
            // Pay
            // 
            Pay.Location = new Point(230, -1);
            Pay.Name = "Pay";
            Pay.Size = new Size(186, 32);
            Pay.TabIndex = 3;
            Pay.Text = "Thanh Toán";
            Pay.UseVisualStyleBackColor = true;
            Pay.Click += Pay_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nnFoodCount);
            panel4.Controls.Add(AddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(466, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(419, 72);
            panel4.TabIndex = 5;
            // 
            // nnFoodCount
            // 
            nnFoodCount.Location = new Point(356, 20);
            nnFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nnFoodCount.Name = "nnFoodCount";
            nnFoodCount.Size = new Size(52, 27);
            nnFoodCount.TabIndex = 3;
            nnFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddFood
            // 
            AddFood.Location = new Point(241, 0);
            AddFood.Name = "AddFood";
            AddFood.Size = new Size(109, 65);
            AddFood.TabIndex = 2;
            AddFood.Text = "Thêm Món";
            AddFood.UseVisualStyleBackColor = true;
            AddFood.Click += AddFood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 37);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(232, 28);
            cbFood.TabIndex = 1;
            cbFood.SelectedIndexChanged += cbFood_SelectedIndexChanged;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(232, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 71);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(414, 548);
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
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
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
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private ComboBox cbCategory;
        private NumericUpDown nnFoodCount;
        private Button AddFood;
        private ComboBox cbFood;
        private FlowLayoutPanel flpTable;
        private Button Pay;
        private NumericUpDown nmDiscount;
        private Button butDiscount;
        private ComboBox cbSwitchTable;
        private Button SwitchTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbtotalPrice;
    }
}