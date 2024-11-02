using QuanLyQuanCAFE.DAO;
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

            dtgvAccount.DataSource = accountList;
            dtgvCategory.DataSource = categoryList;

            AddAccountBinding();
            LoadAccount();
            LoadListTable();
            LoadListCategory();
            ShowRevenue(dateTimePicker01.Value, dateTimePicker02.Value);
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddCategoryBinding();

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
            cbAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void AddCategoryBinding()
        {
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
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
            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void butViewCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }
        private void butEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.UpdateCategory(id,name))
            {
                MessageBox.Show("Sửa danh mục thành công");
                LoadListCategory();
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

        private void butViewTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void LoadListTable()
        {
            dtgvTable.DataSource = TableDAO.Instance.GetTableList();
        }

        private void txbCategoryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
