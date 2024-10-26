namespace QuanLyQuanCAFE
{
    partial class fAmin
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
            tabControl1 = new TabControl();
            tabBill = new TabPage();
            tongDoanhThu = new TextBox();
            doanhThu = new TextBox();
            listBill = new DataGridView();
            panel3 = new Panel();
            button1 = new Button();
            dateTimePicker02 = new DateTimePicker();
            dateTimePicker01 = new DateTimePicker();
            tabFood = new TabPage();
            panel5 = new Panel();
            txbSearchFoodName = new TextBox();
            butSearchFood = new Button();
            panel4 = new Panel();
            butView = new Button();
            butDeleteFood = new Button();
            butEditFood = new Button();
            butAddFood = new Button();
            panel2 = new Panel();
            panel9 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label3 = new Label();
            panel8 = new Panel();
            cbFoodCategory = new ComboBox();
            label2 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            txbFoodName = new TextBox();
            panel6 = new Panel();
            lbUserName = new Label();
            txbFoodID = new TextBox();
            panel1 = new Panel();
            dtgvFood = new DataGridView();
            tabFoodCategory = new TabPage();
            panel11 = new Panel();
            butViewCategory = new Button();
            butDleteCategory = new Button();
            butEditCategory = new Button();
            butAddCategory = new Button();
            panel12 = new Panel();
            panel15 = new Panel();
            label6 = new Label();
            textBox2 = new TextBox();
            panel16 = new Panel();
            label7 = new Label();
            txbCategoryID = new TextBox();
            panel17 = new Panel();
            dtgvCategory = new DataGridView();
            tabTable = new TabPage();
            panel10 = new Panel();
            butViewTable = new Button();
            butDeleteTable = new Button();
            butEditTable = new Button();
            butAddTable = new Button();
            panel13 = new Panel();
            panel20 = new Panel();
            cbTableStatus = new ComboBox();
            label8 = new Label();
            panel14 = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            panel18 = new Panel();
            label5 = new Label();
            textBox3 = new TextBox();
            panel19 = new Panel();
            dtgvTable = new DataGridView();
            tabAccount = new TabPage();
            panel21 = new Panel();
            textBox4 = new TextBox();
            button2 = new Button();
            panel22 = new Panel();
            butViewAccount = new Button();
            butDeleteAccount = new Button();
            butEditAccount = new Button();
            butAddAccount = new Button();
            panel23 = new Panel();
            button3 = new Button();
            panel25 = new Panel();
            cbAccountType = new ComboBox();
            label10 = new Label();
            panel26 = new Panel();
            label11 = new Label();
            txbDisplayName = new TextBox();
            panel27 = new Panel();
            label12 = new Label();
            textBox6 = new TextBox();
            panel28 = new Panel();
            dtgvAccount = new DataGridView();
            tabControl1.SuspendLayout();
            tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listBill).BeginInit();
            panel3.SuspendLayout();
            tabFood.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tabFoodCategory.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            tabTable.SuspendLayout();
            panel10.SuspendLayout();
            panel13.SuspendLayout();
            panel20.SuspendLayout();
            panel14.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            tabAccount.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBill);
            tabControl1.Controls.Add(tabFood);
            tabControl1.Controls.Add(tabFoodCategory);
            tabControl1.Controls.Add(tabTable);
            tabControl1.Controls.Add(tabAccount);
            tabControl1.Location = new Point(18, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(892, 495);
            tabControl1.TabIndex = 0;
            // 
            // tabBill
            // 
            tabBill.Controls.Add(tongDoanhThu);
            tabBill.Controls.Add(doanhThu);
            tabBill.Controls.Add(listBill);
            tabBill.Controls.Add(panel3);
            tabBill.Location = new Point(4, 29);
            tabBill.Name = "tabBill";
            tabBill.Padding = new Padding(3);
            tabBill.Size = new Size(884, 462);
            tabBill.TabIndex = 0;
            tabBill.Text = "Tổng doanh thu";
            tabBill.UseVisualStyleBackColor = true;
            // 
            // tongDoanhThu
            // 
            tongDoanhThu.Location = new Point(137, 418);
            tongDoanhThu.Name = "tongDoanhThu";
            tongDoanhThu.ReadOnly = true;
            tongDoanhThu.Size = new Size(202, 27);
            tongDoanhThu.TabIndex = 5;
            tongDoanhThu.TextAlign = HorizontalAlignment.Center;
            // 
            // doanhThu
            // 
            doanhThu.Location = new Point(6, 418);
            doanhThu.Name = "doanhThu";
            doanhThu.ReadOnly = true;
            doanhThu.Size = new Size(125, 27);
            doanhThu.TabIndex = 4;
            doanhThu.Text = "Tổng doanh thu";
            doanhThu.TextAlign = HorizontalAlignment.Center;
            // 
            // listBill
            // 
            listBill.AllowUserToResizeColumns = false;
            listBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBill.Location = new Point(6, 62);
            listBill.Name = "listBill";
            listBill.ReadOnly = true;
            listBill.RowHeadersWidth = 51;
            listBill.Size = new Size(750, 335);
            listBill.TabIndex = 3;
            listBill.CellContentClick += listBill_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(dateTimePicker02);
            panel3.Controls.Add(dateTimePicker01);
            panel3.Location = new Point(7, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(749, 41);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(328, 7);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker02
            // 
            dateTimePicker02.Location = new Point(483, 7);
            dateTimePicker02.Name = "dateTimePicker02";
            dateTimePicker02.Size = new Size(263, 27);
            dateTimePicker02.TabIndex = 1;
            // 
            // dateTimePicker01
            // 
            dateTimePicker01.Location = new Point(3, 7);
            dateTimePicker01.Name = "dateTimePicker01";
            dateTimePicker01.Size = new Size(260, 27);
            dateTimePicker01.TabIndex = 0;
            // 
            // tabFood
            // 
            tabFood.Controls.Add(panel5);
            tabFood.Controls.Add(panel4);
            tabFood.Controls.Add(panel2);
            tabFood.Controls.Add(panel1);
            tabFood.Location = new Point(4, 29);
            tabFood.Name = "tabFood";
            tabFood.Padding = new Padding(3);
            tabFood.Size = new Size(884, 462);
            tabFood.TabIndex = 1;
            tabFood.Text = "Thức ăn";
            tabFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbSearchFoodName);
            panel5.Controls.Add(butSearchFood);
            panel5.Location = new Point(458, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(420, 69);
            panel5.TabIndex = 3;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(12, 21);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(308, 27);
            txbSearchFoodName.TabIndex = 4;
            // 
            // butSearchFood
            // 
            butSearchFood.Location = new Point(326, 1);
            butSearchFood.Name = "butSearchFood";
            butSearchFood.Size = new Size(94, 63);
            butSearchFood.TabIndex = 3;
            butSearchFood.Text = "Tìm";
            butSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(butView);
            panel4.Controls.Add(butDeleteFood);
            panel4.Controls.Add(butEditFood);
            panel4.Controls.Add(butAddFood);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(446, 69);
            panel4.TabIndex = 2;
            // 
            // butView
            // 
            butView.Location = new Point(322, 3);
            butView.Name = "butView";
            butView.Size = new Size(94, 63);
            butView.TabIndex = 3;
            butView.Text = "Xem";
            butView.UseVisualStyleBackColor = true;
            // 
            // butDeleteFood
            // 
            butDeleteFood.Location = new Point(200, 0);
            butDeleteFood.Name = "butDeleteFood";
            butDeleteFood.Size = new Size(94, 63);
            butDeleteFood.TabIndex = 2;
            butDeleteFood.Text = "Xóa";
            butDeleteFood.UseVisualStyleBackColor = true;
            // 
            // butEditFood
            // 
            butEditFood.Location = new Point(100, 0);
            butEditFood.Name = "butEditFood";
            butEditFood.Size = new Size(94, 63);
            butEditFood.TabIndex = 1;
            butEditFood.Text = "Sửa";
            butEditFood.UseVisualStyleBackColor = true;
            // 
            // butAddFood
            // 
            butAddFood.Location = new Point(0, 3);
            butAddFood.Name = "butAddFood";
            butAddFood.Size = new Size(94, 63);
            butAddFood.TabIndex = 0;
            butAddFood.Text = "Thêm";
            butAddFood.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(458, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 375);
            panel2.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(nmFoodPrice);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 210);
            panel9.Name = "panel9";
            panel9.Size = new Size(414, 63);
            panel9.TabIndex = 6;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(131, 23);
            nmFoodPrice.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(263, 27);
            nmFoodPrice.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 22);
            label3.Name = "label3";
            label3.Size = new Size(49, 24);
            label3.TabIndex = 1;
            label3.Text = "GIá:";
            // 
            // panel8
            // 
            panel8.Controls.Add(cbFoodCategory);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 141);
            panel8.Name = "panel8";
            panel8.Size = new Size(414, 63);
            panel8.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(127, 22);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(267, 28);
            cbFoodCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 22);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 1;
            label2.Text = "Danh mục:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(txbFoodName);
            panel7.Location = new Point(3, 72);
            panel7.Name = "panel7";
            panel7.Size = new Size(414, 63);
            panel7.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 1;
            label1.Text = "Tên món:";
            // 
            // txbFoodName
            // 
            txbFoodName.BackColor = SystemColors.ControlLightLight;
            txbFoodName.Location = new Point(127, 22);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(267, 27);
            txbFoodName.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(lbUserName);
            panel6.Controls.Add(txbFoodID);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(414, 63);
            panel6.TabIndex = 3;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(11, 22);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(36, 24);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "ID:";
            // 
            // txbFoodID
            // 
            txbFoodID.BackColor = SystemColors.ControlLightLight;
            txbFoodID.Location = new Point(127, 22);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(267, 27);
            txbFoodID.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvFood);
            panel1.Location = new Point(6, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 375);
            panel1.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 14);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(440, 347);
            dtgvFood.TabIndex = 0;
            // 
            // tabFoodCategory
            // 
            tabFoodCategory.Controls.Add(panel11);
            tabFoodCategory.Controls.Add(panel12);
            tabFoodCategory.Controls.Add(panel17);
            tabFoodCategory.Location = new Point(4, 29);
            tabFoodCategory.Name = "tabFoodCategory";
            tabFoodCategory.Padding = new Padding(3);
            tabFoodCategory.Size = new Size(884, 462);
            tabFoodCategory.TabIndex = 2;
            tabFoodCategory.Text = "Danh mục";
            tabFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(butViewCategory);
            panel11.Controls.Add(butDleteCategory);
            panel11.Controls.Add(butEditCategory);
            panel11.Controls.Add(butAddCategory);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(446, 69);
            panel11.TabIndex = 6;
            // 
            // butViewCategory
            // 
            butViewCategory.Location = new Point(322, 3);
            butViewCategory.Name = "butViewCategory";
            butViewCategory.Size = new Size(94, 63);
            butViewCategory.TabIndex = 3;
            butViewCategory.Text = "Xem";
            butViewCategory.UseVisualStyleBackColor = true;
            // 
            // butDleteCategory
            // 
            butDleteCategory.Location = new Point(200, 0);
            butDleteCategory.Name = "butDleteCategory";
            butDleteCategory.Size = new Size(94, 63);
            butDleteCategory.TabIndex = 2;
            butDleteCategory.Text = "Xóa";
            butDleteCategory.UseVisualStyleBackColor = true;
            // 
            // butEditCategory
            // 
            butEditCategory.Location = new Point(100, 0);
            butEditCategory.Name = "butEditCategory";
            butEditCategory.Size = new Size(94, 63);
            butEditCategory.TabIndex = 1;
            butEditCategory.Text = "Sửa";
            butEditCategory.UseVisualStyleBackColor = true;
            // 
            // butAddCategory
            // 
            butAddCategory.Location = new Point(0, 3);
            butAddCategory.Name = "butAddCategory";
            butAddCategory.Size = new Size(94, 63);
            butAddCategory.TabIndex = 0;
            butAddCategory.Text = "Thêm";
            butAddCategory.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel16);
            panel12.Location = new Point(458, 81);
            panel12.Name = "panel12";
            panel12.Size = new Size(420, 375);
            panel12.TabIndex = 5;
            // 
            // panel15
            // 
            panel15.Controls.Add(label6);
            panel15.Controls.Add(textBox2);
            panel15.Location = new Point(3, 72);
            panel15.Name = "panel15";
            panel15.Size = new Size(414, 63);
            panel15.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 22);
            label6.Name = "label6";
            label6.Size = new Size(152, 24);
            label6.TabIndex = 1;
            label6.Text = "Tên danh mục:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.Location = new Point(167, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 0;
            // 
            // panel16
            // 
            panel16.Controls.Add(label7);
            panel16.Controls.Add(txbCategoryID);
            panel16.Location = new Point(3, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(414, 63);
            panel16.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 22);
            label7.Name = "label7";
            label7.Size = new Size(36, 24);
            label7.TabIndex = 1;
            label7.Text = "ID:";
            // 
            // txbCategoryID
            // 
            txbCategoryID.BackColor = SystemColors.ControlLightLight;
            txbCategoryID.Location = new Point(167, 22);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(227, 27);
            txbCategoryID.TabIndex = 0;
            // 
            // panel17
            // 
            panel17.Controls.Add(dtgvCategory);
            panel17.Location = new Point(6, 81);
            panel17.Name = "panel17";
            panel17.Size = new Size(446, 375);
            panel17.TabIndex = 4;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 14);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.Size = new Size(440, 347);
            dtgvCategory.TabIndex = 0;
            // 
            // tabTable
            // 
            tabTable.Controls.Add(panel10);
            tabTable.Controls.Add(panel13);
            tabTable.Controls.Add(panel19);
            tabTable.Location = new Point(4, 29);
            tabTable.Name = "tabTable";
            tabTable.Padding = new Padding(3);
            tabTable.Size = new Size(884, 462);
            tabTable.TabIndex = 3;
            tabTable.Text = "Bàn ăn";
            tabTable.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(butViewTable);
            panel10.Controls.Add(butDeleteTable);
            panel10.Controls.Add(butEditTable);
            panel10.Controls.Add(butAddTable);
            panel10.Location = new Point(6, 6);
            panel10.Name = "panel10";
            panel10.Size = new Size(446, 69);
            panel10.TabIndex = 9;
            // 
            // butViewTable
            // 
            butViewTable.Location = new Point(322, 3);
            butViewTable.Name = "butViewTable";
            butViewTable.Size = new Size(94, 63);
            butViewTable.TabIndex = 3;
            butViewTable.Text = "Xem";
            butViewTable.UseVisualStyleBackColor = true;
            // 
            // butDeleteTable
            // 
            butDeleteTable.Location = new Point(200, 0);
            butDeleteTable.Name = "butDeleteTable";
            butDeleteTable.Size = new Size(94, 63);
            butDeleteTable.TabIndex = 2;
            butDeleteTable.Text = "Xóa";
            butDeleteTable.UseVisualStyleBackColor = true;
            // 
            // butEditTable
            // 
            butEditTable.Location = new Point(100, 0);
            butEditTable.Name = "butEditTable";
            butEditTable.Size = new Size(94, 63);
            butEditTable.TabIndex = 1;
            butEditTable.Text = "Sửa";
            butEditTable.UseVisualStyleBackColor = true;
            // 
            // butAddTable
            // 
            butAddTable.Location = new Point(0, 3);
            butAddTable.Name = "butAddTable";
            butAddTable.Size = new Size(94, 63);
            butAddTable.TabIndex = 0;
            butAddTable.Text = "Thêm";
            butAddTable.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel20);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel18);
            panel13.Location = new Point(458, 81);
            panel13.Name = "panel13";
            panel13.Size = new Size(420, 375);
            panel13.TabIndex = 8;
            // 
            // panel20
            // 
            panel20.Controls.Add(cbTableStatus);
            panel20.Controls.Add(label8);
            panel20.Location = new Point(3, 156);
            panel20.Name = "panel20";
            panel20.Size = new Size(414, 63);
            panel20.TabIndex = 5;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(167, 18);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(227, 28);
            cbTableStatus.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 22);
            label8.Name = "label8";
            label8.Size = new Size(113, 24);
            label8.TabIndex = 1;
            label8.Text = "Trạng thái:";
            // 
            // panel14
            // 
            panel14.Controls.Add(label4);
            panel14.Controls.Add(textBox1);
            panel14.Location = new Point(3, 72);
            panel14.Name = "panel14";
            panel14.Size = new Size(414, 63);
            panel14.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 22);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 1;
            label4.Text = "Tên bàn:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(167, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(label5);
            panel18.Controls.Add(textBox3);
            panel18.Location = new Point(3, 3);
            panel18.Name = "panel18";
            panel18.Size = new Size(414, 63);
            panel18.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 22);
            label5.Name = "label5";
            label5.Size = new Size(36, 24);
            label5.TabIndex = 1;
            label5.Text = "ID:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.Location = new Point(167, 22);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.Controls.Add(dtgvTable);
            panel19.Location = new Point(6, 81);
            panel19.Name = "panel19";
            panel19.Size = new Size(446, 375);
            panel19.TabIndex = 7;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 14);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(440, 347);
            dtgvTable.TabIndex = 0;
            // 
            // tabAccount
            // 
            tabAccount.Controls.Add(panel21);
            tabAccount.Controls.Add(panel22);
            tabAccount.Controls.Add(panel23);
            tabAccount.Controls.Add(panel28);
            tabAccount.Location = new Point(4, 29);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(3);
            tabAccount.Size = new Size(884, 462);
            tabAccount.TabIndex = 4;
            tabAccount.Text = "Tài khoản";
            tabAccount.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            panel21.Controls.Add(textBox4);
            panel21.Controls.Add(button2);
            panel21.Location = new Point(458, 6);
            panel21.Name = "panel21";
            panel21.Size = new Size(420, 69);
            panel21.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 21);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(308, 27);
            textBox4.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(326, 1);
            button2.Name = "button2";
            button2.Size = new Size(94, 63);
            button2.TabIndex = 3;
            button2.Text = "Tìm";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            panel22.Controls.Add(butViewAccount);
            panel22.Controls.Add(butDeleteAccount);
            panel22.Controls.Add(butEditAccount);
            panel22.Controls.Add(butAddAccount);
            panel22.Location = new Point(6, 6);
            panel22.Name = "panel22";
            panel22.Size = new Size(446, 69);
            panel22.TabIndex = 6;
            // 
            // butViewAccount
            // 
            butViewAccount.Location = new Point(322, 3);
            butViewAccount.Name = "butViewAccount";
            butViewAccount.Size = new Size(94, 63);
            butViewAccount.TabIndex = 3;
            butViewAccount.Text = "Xem";
            butViewAccount.UseVisualStyleBackColor = true;
            // 
            // butDeleteAccount
            // 
            butDeleteAccount.Location = new Point(200, 0);
            butDeleteAccount.Name = "butDeleteAccount";
            butDeleteAccount.Size = new Size(94, 63);
            butDeleteAccount.TabIndex = 2;
            butDeleteAccount.Text = "Xóa";
            butDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // butEditAccount
            // 
            butEditAccount.Location = new Point(100, 0);
            butEditAccount.Name = "butEditAccount";
            butEditAccount.Size = new Size(94, 63);
            butEditAccount.TabIndex = 1;
            butEditAccount.Text = "Sửa";
            butEditAccount.UseVisualStyleBackColor = true;
            // 
            // butAddAccount
            // 
            butAddAccount.Location = new Point(0, 3);
            butAddAccount.Name = "butAddAccount";
            butAddAccount.Size = new Size(94, 63);
            butAddAccount.TabIndex = 0;
            butAddAccount.Text = "Thêm";
            butAddAccount.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            panel23.Controls.Add(button3);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel26);
            panel23.Controls.Add(panel27);
            panel23.Location = new Point(458, 81);
            panel23.Name = "panel23";
            panel23.Size = new Size(420, 375);
            panel23.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(226, 227);
            button3.Name = "button3";
            button3.Size = new Size(135, 63);
            button3.TabIndex = 6;
            button3.Text = "Đặt lại mật khẩu";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            panel25.Controls.Add(cbAccountType);
            panel25.Controls.Add(label10);
            panel25.Location = new Point(3, 141);
            panel25.Name = "panel25";
            panel25.Size = new Size(414, 63);
            panel25.TabIndex = 5;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(185, 22);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(209, 28);
            cbAccountType.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 22);
            label10.Name = "label10";
            label10.Size = new Size(150, 24);
            label10.TabIndex = 1;
            label10.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            panel26.Controls.Add(label11);
            panel26.Controls.Add(txbDisplayName);
            panel26.Location = new Point(3, 72);
            panel26.Name = "panel26";
            panel26.Size = new Size(414, 63);
            panel26.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(9, 22);
            label11.Name = "label11";
            label11.Size = new Size(129, 24);
            label11.TabIndex = 1;
            label11.Text = "Tên hiển thị:";
            // 
            // txbDisplayName
            // 
            txbDisplayName.BackColor = SystemColors.ControlLightLight;
            txbDisplayName.Location = new Point(185, 22);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(209, 27);
            txbDisplayName.TabIndex = 0;
            // 
            // panel27
            // 
            panel27.Controls.Add(label12);
            panel27.Controls.Add(textBox6);
            panel27.Location = new Point(3, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(414, 63);
            panel27.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(11, 22);
            label12.Name = "label12";
            label12.Size = new Size(146, 24);
            label12.TabIndex = 1;
            label12.Text = "Tên tài khoản:";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ControlLightLight;
            textBox6.Location = new Point(185, 22);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(209, 27);
            textBox6.TabIndex = 0;
            // 
            // panel28
            // 
            panel28.Controls.Add(dtgvAccount);
            panel28.Location = new Point(6, 81);
            panel28.Name = "panel28";
            panel28.Size = new Size(446, 375);
            panel28.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 14);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(440, 347);
            dtgvAccount.TabIndex = 0;
            // 
            // fAmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 519);
            Controls.Add(tabControl1);
            Name = "fAmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAmin";
            tabControl1.ResumeLayout(false);
            tabBill.ResumeLayout(false);
            tabBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listBill).EndInit();
            panel3.ResumeLayout(false);
            tabFood.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tabFoodCategory.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            tabTable.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            tabAccount.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel22.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabBill;
        private TabPage tabFood;
        private TabPage tabFoodCategory;
        private TabPage tabTable;
        private TabPage tabAccount;
        private DataGridView listBill;
        private Panel panel3;
        private Button button1;
        private DateTimePicker dateTimePicker02;
        private DateTimePicker dateTimePicker01;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dtgvFood;
        private Button butDeleteFood;
        private Button butEditFood;
        private Button butAddFood;
        private TextBox txbSearchFoodName;
        private Button butSearchFood;
        private Button butView;
        private Panel panel7;
        private Label label1;
        private TextBox txbFoodName;
        private Panel panel6;
        private Label lbUserName;
        private TextBox txbFoodID;
        private Panel panel8;
        private Label label2;
        private Panel panel9;
        private NumericUpDown nmFoodPrice;
        private Label label3;
        private ComboBox cbFoodCategory;
        private Panel panel11;
        private Button butViewCategory;
        private Button butDleteCategory;
        private Button butEditCategory;
        private Button butAddCategory;
        private Panel panel12;
        private Panel panel15;
        private Label label6;
        private TextBox textBox2;
        private Panel panel16;
        private Label label7;
        private TextBox txbCategoryID;
        private Panel panel17;
        private DataGridView dtgvCategory;
        private Panel panel10;
        private Button butViewTable;
        private Button butDeleteTable;
        private Button butEditTable;
        private Button butAddTable;
        private Panel panel13;
        private Panel panel14;
        private Label label4;
        private TextBox textBox1;
        private Panel panel18;
        private Label label5;
        private TextBox textBox3;
        private Panel panel19;
        private DataGridView dtgvTable;
        private Panel panel20;
        private ComboBox cbTableStatus;
        private Label label8;
        private Panel panel21;
        private TextBox textBox4;
        private Button button2;
        private Panel panel22;
        private Button butViewAccount;
        private Button butDeleteAccount;
        private Button butEditAccount;
        private Button butAddAccount;
        private Panel panel23;
        private Panel panel24;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Panel panel25;
        private ComboBox cbAccountType;
        private Label label10;
        private Panel panel26;
        private Label label11;
        private TextBox txbDisplayName;
        private Panel panel27;
        private Label label12;
        private TextBox textBox6;
        private Panel panel28;
        private DataGridView dtgvAccount;
        private Button button3;
        private TextBox doanhThu;
        private TextBox tongDoanhThu;
    }
}