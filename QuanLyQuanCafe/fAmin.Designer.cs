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
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
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
            txbUserName = new TextBox();
            panel28 = new Panel();
            dtgvAccount = new DataGridView();
            tabControl1.SuspendLayout();
            tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Location = new Point(16, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(780, 371);
            tabControl1.TabIndex = 0;
            // 
            // tabBill
            // 
            tabBill.Controls.Add(dataGridView1);
            tabBill.Controls.Add(panel3);
            tabBill.Location = new Point(4, 24);
            tabBill.Margin = new Padding(3, 2, 3, 2);
            tabBill.Name = "tabBill";
            tabBill.Padding = new Padding(3, 2, 3, 2);
            tabBill.Size = new Size(772, 343);
            tabBill.TabIndex = 0;
            tabBill.Text = "Doanh thu";
            tabBill.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 46);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(656, 296);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Location = new Point(6, 4);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(655, 31);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(287, 5);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(423, 5);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(3, 5);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 23);
            dateTimePicker2.TabIndex = 0;
            // 
            // tabFood
            // 
            tabFood.Controls.Add(panel5);
            tabFood.Controls.Add(panel4);
            tabFood.Controls.Add(panel2);
            tabFood.Controls.Add(panel1);
            tabFood.Location = new Point(4, 24);
            tabFood.Margin = new Padding(3, 2, 3, 2);
            tabFood.Name = "tabFood";
            tabFood.Padding = new Padding(3, 2, 3, 2);
            tabFood.Size = new Size(772, 343);
            tabFood.TabIndex = 1;
            tabFood.Text = "Thức ăn";
            tabFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbSearchFoodName);
            panel5.Controls.Add(butSearchFood);
            panel5.Location = new Point(401, 4);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(368, 52);
            panel5.TabIndex = 3;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(10, 16);
            txbSearchFoodName.Margin = new Padding(3, 2, 3, 2);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(270, 23);
            txbSearchFoodName.TabIndex = 4;
            // 
            // butSearchFood
            // 
            butSearchFood.Location = new Point(285, 1);
            butSearchFood.Margin = new Padding(3, 2, 3, 2);
            butSearchFood.Name = "butSearchFood";
            butSearchFood.Size = new Size(82, 47);
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
            panel4.Location = new Point(5, 4);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 52);
            panel4.TabIndex = 2;
            // 
            // butView
            // 
            butView.Location = new Point(282, 2);
            butView.Margin = new Padding(3, 2, 3, 2);
            butView.Name = "butView";
            butView.Size = new Size(82, 47);
            butView.TabIndex = 3;
            butView.Text = "Xem";
            butView.UseVisualStyleBackColor = true;
            // 
            // butDeleteFood
            // 
            butDeleteFood.Location = new Point(175, 0);
            butDeleteFood.Margin = new Padding(3, 2, 3, 2);
            butDeleteFood.Name = "butDeleteFood";
            butDeleteFood.Size = new Size(82, 47);
            butDeleteFood.TabIndex = 2;
            butDeleteFood.Text = "Xóa";
            butDeleteFood.UseVisualStyleBackColor = true;
            // 
            // butEditFood
            // 
            butEditFood.Location = new Point(88, 0);
            butEditFood.Margin = new Padding(3, 2, 3, 2);
            butEditFood.Name = "butEditFood";
            butEditFood.Size = new Size(82, 47);
            butEditFood.TabIndex = 1;
            butEditFood.Text = "Sửa";
            butEditFood.UseVisualStyleBackColor = true;
            // 
            // butAddFood
            // 
            butAddFood.Location = new Point(0, 2);
            butAddFood.Margin = new Padding(3, 2, 3, 2);
            butAddFood.Name = "butAddFood";
            butAddFood.Size = new Size(82, 47);
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
            panel2.Location = new Point(401, 61);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 281);
            panel2.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(nmFoodPrice);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 158);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(362, 47);
            panel9.TabIndex = 6;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(115, 17);
            nmFoodPrice.Margin = new Padding(3, 2, 3, 2);
            nmFoodPrice.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(230, 23);
            nmFoodPrice.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 16);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 1;
            label3.Text = "GIá:";
            // 
            // panel8
            // 
            panel8.Controls.Add(cbFoodCategory);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 106);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(362, 47);
            panel8.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(111, 16);
            cbFoodCategory.Margin = new Padding(3, 2, 3, 2);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(234, 23);
            cbFoodCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 16);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 1;
            label2.Text = "Danh mục:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(txbFoodName);
            panel7.Location = new Point(3, 54);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(362, 47);
            panel7.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 1;
            label1.Text = "Tên món:";
            // 
            // txbFoodName
            // 
            txbFoodName.BackColor = SystemColors.ControlLightLight;
            txbFoodName.Location = new Point(111, 16);
            txbFoodName.Margin = new Padding(3, 2, 3, 2);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(234, 23);
            txbFoodName.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(lbUserName);
            panel6.Controls.Add(txbFoodID);
            panel6.Location = new Point(3, 2);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(362, 47);
            panel6.TabIndex = 3;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(10, 16);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(31, 19);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "ID:";
            // 
            // txbFoodID
            // 
            txbFoodID.BackColor = SystemColors.ControlLightLight;
            txbFoodID.Location = new Point(111, 16);
            txbFoodID.Margin = new Padding(3, 2, 3, 2);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(234, 23);
            txbFoodID.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvFood);
            panel1.Location = new Point(5, 61);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 281);
            panel1.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 10);
            dtgvFood.Margin = new Padding(3, 2, 3, 2);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(385, 260);
            dtgvFood.TabIndex = 0;
            // 
            // tabFoodCategory
            // 
            tabFoodCategory.Controls.Add(panel11);
            tabFoodCategory.Controls.Add(panel12);
            tabFoodCategory.Controls.Add(panel17);
            tabFoodCategory.Location = new Point(4, 24);
            tabFoodCategory.Margin = new Padding(3, 2, 3, 2);
            tabFoodCategory.Name = "tabFoodCategory";
            tabFoodCategory.Padding = new Padding(3, 2, 3, 2);
            tabFoodCategory.Size = new Size(772, 343);
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
            panel11.Location = new Point(5, 4);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(390, 52);
            panel11.TabIndex = 6;
            // 
            // butViewCategory
            // 
            butViewCategory.Location = new Point(282, 2);
            butViewCategory.Margin = new Padding(3, 2, 3, 2);
            butViewCategory.Name = "butViewCategory";
            butViewCategory.Size = new Size(82, 47);
            butViewCategory.TabIndex = 3;
            butViewCategory.Text = "Xem";
            butViewCategory.UseVisualStyleBackColor = true;
            // 
            // butDleteCategory
            // 
            butDleteCategory.Location = new Point(175, 0);
            butDleteCategory.Margin = new Padding(3, 2, 3, 2);
            butDleteCategory.Name = "butDleteCategory";
            butDleteCategory.Size = new Size(82, 47);
            butDleteCategory.TabIndex = 2;
            butDleteCategory.Text = "Xóa";
            butDleteCategory.UseVisualStyleBackColor = true;
            // 
            // butEditCategory
            // 
            butEditCategory.Location = new Point(88, 0);
            butEditCategory.Margin = new Padding(3, 2, 3, 2);
            butEditCategory.Name = "butEditCategory";
            butEditCategory.Size = new Size(82, 47);
            butEditCategory.TabIndex = 1;
            butEditCategory.Text = "Sửa";
            butEditCategory.UseVisualStyleBackColor = true;
            // 
            // butAddCategory
            // 
            butAddCategory.Location = new Point(0, 2);
            butAddCategory.Margin = new Padding(3, 2, 3, 2);
            butAddCategory.Name = "butAddCategory";
            butAddCategory.Size = new Size(82, 47);
            butAddCategory.TabIndex = 0;
            butAddCategory.Text = "Thêm";
            butAddCategory.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel16);
            panel12.Location = new Point(401, 61);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(368, 281);
            panel12.TabIndex = 5;
            // 
            // panel15
            // 
            panel15.Controls.Add(label6);
            panel15.Controls.Add(textBox2);
            panel15.Location = new Point(3, 54);
            panel15.Margin = new Padding(3, 2, 3, 2);
            panel15.Name = "panel15";
            panel15.Size = new Size(362, 47);
            panel15.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 16);
            label6.Name = "label6";
            label6.Size = new Size(124, 19);
            label6.TabIndex = 1;
            label6.Text = "Tên danh mục:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.Location = new Point(146, 16);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 0;
            // 
            // panel16
            // 
            panel16.Controls.Add(label7);
            panel16.Controls.Add(txbCategoryID);
            panel16.Location = new Point(3, 2);
            panel16.Margin = new Padding(3, 2, 3, 2);
            panel16.Name = "panel16";
            panel16.Size = new Size(362, 47);
            panel16.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 16);
            label7.Name = "label7";
            label7.Size = new Size(31, 19);
            label7.TabIndex = 1;
            label7.Text = "ID:";
            // 
            // txbCategoryID
            // 
            txbCategoryID.BackColor = SystemColors.ControlLightLight;
            txbCategoryID.Location = new Point(146, 16);
            txbCategoryID.Margin = new Padding(3, 2, 3, 2);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(199, 23);
            txbCategoryID.TabIndex = 0;
            // 
            // panel17
            // 
            panel17.Controls.Add(dtgvCategory);
            panel17.Location = new Point(5, 61);
            panel17.Margin = new Padding(3, 2, 3, 2);
            panel17.Name = "panel17";
            panel17.Size = new Size(390, 281);
            panel17.TabIndex = 4;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 10);
            dtgvCategory.Margin = new Padding(3, 2, 3, 2);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.Size = new Size(385, 260);
            dtgvCategory.TabIndex = 0;
            // 
            // tabTable
            // 
            tabTable.Controls.Add(panel10);
            tabTable.Controls.Add(panel13);
            tabTable.Controls.Add(panel19);
            tabTable.Location = new Point(4, 24);
            tabTable.Margin = new Padding(3, 2, 3, 2);
            tabTable.Name = "tabTable";
            tabTable.Padding = new Padding(3, 2, 3, 2);
            tabTable.Size = new Size(772, 343);
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
            panel10.Location = new Point(5, 4);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(390, 52);
            panel10.TabIndex = 9;
            // 
            // butViewTable
            // 
            butViewTable.Location = new Point(282, 2);
            butViewTable.Margin = new Padding(3, 2, 3, 2);
            butViewTable.Name = "butViewTable";
            butViewTable.Size = new Size(82, 47);
            butViewTable.TabIndex = 3;
            butViewTable.Text = "Xem";
            butViewTable.UseVisualStyleBackColor = true;
            // 
            // butDeleteTable
            // 
            butDeleteTable.Location = new Point(175, 0);
            butDeleteTable.Margin = new Padding(3, 2, 3, 2);
            butDeleteTable.Name = "butDeleteTable";
            butDeleteTable.Size = new Size(82, 47);
            butDeleteTable.TabIndex = 2;
            butDeleteTable.Text = "Xóa";
            butDeleteTable.UseVisualStyleBackColor = true;
            // 
            // butEditTable
            // 
            butEditTable.Location = new Point(88, 0);
            butEditTable.Margin = new Padding(3, 2, 3, 2);
            butEditTable.Name = "butEditTable";
            butEditTable.Size = new Size(82, 47);
            butEditTable.TabIndex = 1;
            butEditTable.Text = "Sửa";
            butEditTable.UseVisualStyleBackColor = true;
            // 
            // butAddTable
            // 
            butAddTable.Location = new Point(0, 2);
            butAddTable.Margin = new Padding(3, 2, 3, 2);
            butAddTable.Name = "butAddTable";
            butAddTable.Size = new Size(82, 47);
            butAddTable.TabIndex = 0;
            butAddTable.Text = "Thêm";
            butAddTable.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel20);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel18);
            panel13.Location = new Point(401, 61);
            panel13.Margin = new Padding(3, 2, 3, 2);
            panel13.Name = "panel13";
            panel13.Size = new Size(368, 281);
            panel13.TabIndex = 8;
            // 
            // panel20
            // 
            panel20.Controls.Add(cbTableStatus);
            panel20.Controls.Add(label8);
            panel20.Location = new Point(3, 117);
            panel20.Margin = new Padding(3, 2, 3, 2);
            panel20.Name = "panel20";
            panel20.Size = new Size(362, 47);
            panel20.TabIndex = 5;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(146, 14);
            cbTableStatus.Margin = new Padding(3, 2, 3, 2);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(199, 23);
            cbTableStatus.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 16);
            label8.Name = "label8";
            label8.Size = new Size(91, 19);
            label8.TabIndex = 1;
            label8.Text = "Trạng thái:";
            // 
            // panel14
            // 
            panel14.Controls.Add(label4);
            panel14.Controls.Add(textBox1);
            panel14.Location = new Point(3, 54);
            panel14.Margin = new Padding(3, 2, 3, 2);
            panel14.Name = "panel14";
            panel14.Size = new Size(362, 47);
            panel14.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 16);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 1;
            label4.Text = "Tên bàn:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(146, 16);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(label5);
            panel18.Controls.Add(textBox3);
            panel18.Location = new Point(3, 2);
            panel18.Margin = new Padding(3, 2, 3, 2);
            panel18.Name = "panel18";
            panel18.Size = new Size(362, 47);
            panel18.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 16);
            label5.Name = "label5";
            label5.Size = new Size(31, 19);
            label5.TabIndex = 1;
            label5.Text = "ID:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.Location = new Point(146, 16);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(199, 23);
            textBox3.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.Controls.Add(dtgvTable);
            panel19.Location = new Point(5, 61);
            panel19.Margin = new Padding(3, 2, 3, 2);
            panel19.Name = "panel19";
            panel19.Size = new Size(390, 281);
            panel19.TabIndex = 7;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 10);
            dtgvTable.Margin = new Padding(3, 2, 3, 2);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(385, 260);
            dtgvTable.TabIndex = 0;
            // 
            // tabAccount
            // 
            tabAccount.Controls.Add(panel21);
            tabAccount.Controls.Add(panel22);
            tabAccount.Controls.Add(panel23);
            tabAccount.Controls.Add(panel28);
            tabAccount.Location = new Point(4, 24);
            tabAccount.Margin = new Padding(3, 2, 3, 2);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(3, 2, 3, 2);
            tabAccount.Size = new Size(772, 343);
            tabAccount.TabIndex = 4;
            tabAccount.Text = "Tài khoản";
            tabAccount.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            panel21.Controls.Add(textBox4);
            panel21.Controls.Add(button2);
            panel21.Location = new Point(401, 4);
            panel21.Margin = new Padding(3, 2, 3, 2);
            panel21.Name = "panel21";
            panel21.Size = new Size(368, 52);
            panel21.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(10, 16);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 23);
            textBox4.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(285, 1);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 47);
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
            panel22.Location = new Point(5, 4);
            panel22.Margin = new Padding(3, 2, 3, 2);
            panel22.Name = "panel22";
            panel22.Size = new Size(390, 52);
            panel22.TabIndex = 6;
            // 
            // butViewAccount
            // 
            butViewAccount.Location = new Point(282, 2);
            butViewAccount.Margin = new Padding(3, 2, 3, 2);
            butViewAccount.Name = "butViewAccount";
            butViewAccount.Size = new Size(82, 47);
            butViewAccount.TabIndex = 3;
            butViewAccount.Text = "Xem";
            butViewAccount.UseVisualStyleBackColor = true;
            butViewAccount.Click += butViewAccount_Click;
            // 
            // butDeleteAccount
            // 
            butDeleteAccount.Location = new Point(175, 0);
            butDeleteAccount.Margin = new Padding(3, 2, 3, 2);
            butDeleteAccount.Name = "butDeleteAccount";
            butDeleteAccount.Size = new Size(82, 47);
            butDeleteAccount.TabIndex = 2;
            butDeleteAccount.Text = "Xóa";
            butDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // butEditAccount
            // 
            butEditAccount.Location = new Point(88, 0);
            butEditAccount.Margin = new Padding(3, 2, 3, 2);
            butEditAccount.Name = "butEditAccount";
            butEditAccount.Size = new Size(82, 47);
            butEditAccount.TabIndex = 1;
            butEditAccount.Text = "Sửa";
            butEditAccount.UseVisualStyleBackColor = true;
            // 
            // butAddAccount
            // 
            butAddAccount.Location = new Point(0, 2);
            butAddAccount.Margin = new Padding(3, 2, 3, 2);
            butAddAccount.Name = "butAddAccount";
            butAddAccount.Size = new Size(82, 47);
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
            panel23.Location = new Point(401, 61);
            panel23.Margin = new Padding(3, 2, 3, 2);
            panel23.Name = "panel23";
            panel23.Size = new Size(368, 281);
            panel23.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(198, 170);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(118, 47);
            button3.TabIndex = 6;
            button3.Text = "Đặt lại mật khẩu";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            panel25.Controls.Add(cbAccountType);
            panel25.Controls.Add(label10);
            panel25.Location = new Point(3, 106);
            panel25.Margin = new Padding(3, 2, 3, 2);
            panel25.Name = "panel25";
            panel25.Size = new Size(362, 47);
            panel25.TabIndex = 5;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(162, 16);
            cbAccountType.Margin = new Padding(3, 2, 3, 2);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(183, 23);
            cbAccountType.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(8, 16);
            label10.Name = "label10";
            label10.Size = new Size(122, 19);
            label10.TabIndex = 1;
            label10.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            panel26.Controls.Add(label11);
            panel26.Controls.Add(txbDisplayName);
            panel26.Location = new Point(3, 54);
            panel26.Margin = new Padding(3, 2, 3, 2);
            panel26.Name = "panel26";
            panel26.Size = new Size(362, 47);
            panel26.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(8, 16);
            label11.Name = "label11";
            label11.Size = new Size(104, 19);
            label11.TabIndex = 1;
            label11.Text = "Tên hiển thị:";
            // 
            // txbDisplayName
            // 
            txbDisplayName.BackColor = SystemColors.ControlLightLight;
            txbDisplayName.Location = new Point(162, 16);
            txbDisplayName.Margin = new Padding(3, 2, 3, 2);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(183, 23);
            txbDisplayName.TabIndex = 0;
            // 
            // panel27
            // 
            panel27.Controls.Add(label12);
            panel27.Controls.Add(txbUserName);
            panel27.Location = new Point(3, 2);
            panel27.Margin = new Padding(3, 2, 3, 2);
            panel27.Name = "panel27";
            panel27.Size = new Size(362, 47);
            panel27.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 16);
            label12.Name = "label12";
            label12.Size = new Size(118, 19);
            label12.TabIndex = 1;
            label12.Text = "Tên tài khoản:";
            // 
            // txbUserName
            // 
            txbUserName.BackColor = SystemColors.ControlLightLight;
            txbUserName.Location = new Point(162, 16);
            txbUserName.Margin = new Padding(3, 2, 3, 2);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(183, 23);
            txbUserName.TabIndex = 0;
            // 
            // panel28
            // 
            panel28.Controls.Add(dtgvAccount);
            panel28.Location = new Point(5, 61);
            panel28.Margin = new Padding(3, 2, 3, 2);
            panel28.Name = "panel28";
            panel28.Size = new Size(390, 281);
            panel28.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 10);
            dtgvAccount.Margin = new Padding(3, 2, 3, 2);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(385, 260);
            dtgvAccount.TabIndex = 0;
            // 
            // fAmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 389);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fAmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAmin";
            tabControl1.ResumeLayout(false);
            tabBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
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
        private TextBox txbUserName;
        private Panel panel28;
        private DataGridView dtgvAccount;
        private Button button3;
    }
}