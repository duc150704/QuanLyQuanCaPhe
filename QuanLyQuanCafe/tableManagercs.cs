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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCAFE
{
    public partial class tableManagercs : Form
    {
        public tableManagercs()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadComboBoxTable(cbSwitchTable);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        #region Events

        private void btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;

            ShowBill(tableID);
        }



        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAmin f = new fAmin();
            f.ShowDialog();

        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcountProfile f = new AcountProfile();
            f.ShowDialog();
        }
        #endregion
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bạn chưa nhấn chọn bàn!", "Lưu ý", MessageBoxButtons.OK);
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDBytableID(table.ID);
            int idFood = (cbFood.SelectedItem as Food).Id;
            int count = (int)nnFoodCount.Value;


            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfor(BillDAO.Instance.GetMaxIdBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfor(idBill, idFood, count);

            }

            ShowBill(table.ID);
            LoadTable();
        }

        #region

        void LoadCategory()
        {
            List<Category> list = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = list;
            cbCategory.DisplayMember = "name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> list = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = list;
            cbFood.DisplayMember = "name";
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table t in tableList)
            {
                Button btn = new Button()
                {
                    Width = TableDAO.TableWidth,
                    Height = TableDAO.TableHeight
                };
                btn.Text = t.Name + Environment.NewLine + t.Status;
                btn.Click += btn_Click;
                btn.Tag = t;


                if (t.Status.Equals("Trống"))
                {
                    btn.BackColor = Color.Gray;
                }
                else
                {
                    btn.BackColor = Color.LightSeaGreen;
                }

                flpTable.Controls.Add(btn);
            }


        }

        private void ShowBill(int id)
        {
            lsvBill.Items.Clear();

            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;


            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                totalPrice += item.TotalPrice;


                lsvBill.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");

            txbtotalPrice.Text = totalPrice.ToString("c", culture);



        }
        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }

            Category selected = cb.SelectedItem as Category;
            id = selected.Id;


            LoadFoodListByCategoryID(id);
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Bạn chưa nhấn chọn bàn!", "Lưu ý", MessageBoxButtons.OK);
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDBytableID(table.ID);
            int discount = (int)nmDiscount.Value;



            double totalPrice = Convert.ToDouble(txbtotalPrice.Text.Split(',')[0].Replace(".", "").Replace("₫", ""));
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc muốn thanh toán cho " + table.Name + "\nTổng tiền: " + totalPrice.ToString("c", new CultureInfo("vi-VN"))
                    + "\nGiảm giá: " + discount + "%\nThành tiền: " + finalTotalPrice.ToString("c", new CultureInfo("vi-VN"))
                    , "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }

        }

        private void SwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID; //lấy ra id table đang chọn
            int id2 = (cbSwitchTable.SelectedItem as Table).ID; //lấy ra id table muốn chuyển bàn


            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} qua bàn {1} không?", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }

        public void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        private void txbtotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
