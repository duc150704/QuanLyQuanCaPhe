using QuanLyQuanCAFE.DAO;
using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCAFE
{
    public partial class AdminUI : Form
    {
        BindingSource accountList = new BindingSource();
        BindingSource tableList = new BindingSource();


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
            dtgvTable.DataSource = tableList;

            AddAccountBinding();
            LoadAccount();
            LoadListTable();
            LoadListCategory();
            ShowRevenue(dateTimePicker01.Value, dateTimePicker02.Value);
            LoadListFood();
            AddTableFoodBinding();

        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            cbAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
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
            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void butViewCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void LoadListCategory()
        {
            dtgvCategory.DataSource = CategoryDAO.Instance.GetListCategory();
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
    }
}
