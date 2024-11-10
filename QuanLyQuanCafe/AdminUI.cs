
﻿using QuanLyQuanCAFE.DAO;

using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCAFE
{
    public partial class AdminUI : Form
    {
        BindingSource accountList = new BindingSource();

        BindingSource categoryList = new BindingSource();

        BindingSource tableList = new BindingSource();
        BindingSource foodList = new BindingSource();


        public Account loginAcount;

        public AdminUI()
        {
            InitializeComponent();
            Load();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Load()
        {
            LoadDateTimePicker();
            LoadListBillByDate(dateTimePicker01.Value, dateTimePicker02.Value);

            dtgvCategory.DataSource = categoryList;

            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            dtgvTable.DataSource = tableList;

            AddAccountBinding();
            LoadAccount();
            LoadListTable();
            LoadListCategory();
            ShowRevenue(dateTimePicker01.Value, dateTimePicker02.Value);
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddCategoryBinding();

            AddTableFoodBinding();

            AddFoodBinding();

         //   LoadTableStatus(cbTableStatus);

        }
        private event EventHandler insertCategory;
        private event EventHandler updateCategory;
        private event EventHandler deleteCategory;

        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }



        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmTypeAccount.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void AddCategoryBinding()
        {
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }


        void AddTableFoodBinding()
        {
            txtTableId.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
            cbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void butViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDateTimePicker();
            LoadListBillByDate(dateTimePicker01.Value, dateTimePicker02.Value);
            ShowRevenue(dateTimePicker01.Value, dateTimePicker02.Value);
        }

        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dateTimePicker01.Value = new DateTime(today.Year, today.Month, 1);

            dateTimePicker02.Value = dateTimePicker01.Value.AddMonths(1).AddDays(-1);
        }

        public void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            listBill.DataSource = BillDAO.Instance.LoadListBillByDate(checkIn, checkOut);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePicker01.Value, dateTimePicker02.Value);
            ShowRevenue(dateTimePicker01.Value, dateTimePicker02.Value);
        }

        private void listBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ShowRevenue(DateTime d1, DateTime d2)
        {
            float revenue = 0;
            DataTable data = BillDAO.Instance.GetRevenueFromDateToDate(d1, d2);
            if (data == null || data.Rows.Count == 0 || data.Rows[0][0] == DBNull.Value)
            {
                tongDoanhThu.Text = "0";
                return;
            }
            if (data.Rows.Count > 0)
            {
                revenue = Convert.ToSingle(data.Rows[0][0]);
            }

            tongDoanhThu.Text = revenue.ToString("c", new CultureInfo("vi-VN"));
        }

        private void butView_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        void LoadListFood()
        {

            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        //void LoadTableStatus(ComboBox cb)
        //{
        //    List<string> list = new List<string> { "Trống", "Có người" };
        //    cb.DataSource = list;
        //}


        private void butViewCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }


        private void butViewTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.GetTableList();
        }

        private void tongDoanhThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void butAddTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            if (name.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên bàn!");
                return;
            }

            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công!");

                LoadListTable();
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm bàn KHÔNG thành công!");
            }
        }

        private void butEditTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            int id = Convert.ToInt32(txtTableId.Text);

            if (name.Equals(""))
            {
                MessageBox.Show("Tên bàn không được để trống!");
                return;
            }

            if (TableDAO.Instance.UpdateTable(id, name))
            {
                MessageBox.Show("Sửa bàn thành công!");

                LoadListTable();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa bàn KHÔNG thành công!");
            }
        }

        private void butDeleteTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            int id = Convert.ToInt32(txtTableId.Text);

            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công!");

                LoadListTable();
                if (deleteTable != null)
                    deleteTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Xóa bàn KHÔNG thành công!");
            }
        }

        private void dtgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }



        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }



        private void butAddFood_Click_1(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).Id;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void butEditFood_Click_1(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).Id;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void butDeleteFood_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        private void butEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa danh mục thành công");
                LoadListCategory();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục");
            }
        }

        private void butDleteCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công");
                LoadListCategory();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (deleteCategory != null)
                    deleteCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa danh mục");
            }
        }

        private void butAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục  thành công");
                LoadListCategory();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
        }

        private void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        private void butAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmTypeAccount.Value;


            AddAccount(userName, displayName, type);
        }

        private void butEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmTypeAccount.Value;

            EditAccount(userName, displayName, type);
        }

        private void butDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            DeleteAccount(userName);
        }

        public void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản không thành công!");
            }
        }

        public void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.EditAccount(userName, displayName, type))
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Sửa tài khoản không thành công!");
            }
        }
        public void DeleteAccount(string userName)
        {
            if (loginAcount.UserName.Equals(userName))
            {
                MessageBox.Show("Không thể tự xóa chính mình!");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản không thành công!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            ResetPassword(userName);


        }

        public void ResetPassword(string userName)
        {

            if (AccountDAO.Instance.ResetAccount(userName))
            {
                MessageBox.Show("Đã đặt lại mật khẩu mặc định là \"admin\"");
            }
        }

        private void txbFoodID_TextChanged_1(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;

                Category category = CategoryDAO.Instance.GetCategoryByID(id);

                cbFoodCategory.SelectedItem = category;

                int index = -1;
                int i = 0;
                foreach (Category item in cbFoodCategory.Items)
                {
                    if (item.Id == category.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbFoodCategory.SelectedIndex = index;
            }
        }

        private void nmFoodPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void butSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> foodList = new List<Food>();
            foodList = FoodDAO.Instance.GetFoodList(name);
            return foodList;
        }
    }
}
