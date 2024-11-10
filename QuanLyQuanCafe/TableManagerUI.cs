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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace QuanLyQuanCAFE
{
    public partial class TableManagerUI : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; ChangeAccount(loginAccount.Type); } }

        public TableManagerUI(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            LoadTable();
            LoadCategory();
            LoadComboBoxTable(cbSwitchTable);
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1 ? true : false;
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


            

        private void f_UpdateCategory(object? sender, EventArgs e)
        {
            LoadCategory();
        }

        private void f_DeleteCategory(object? sender, EventArgs e)
        {
            LoadCategory();
        }

        private void f_InsertCategory(object? sender, EventArgs e)
        {
            LoadCategory();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AdminUI f = new AdminUI();
                f.loginAcount = LoginAccount;

                f.InsertTable += f_InsertTable;
                f.UpdateTable += f_UpdateTable;
                f.DeleteTable += f_DeleteTable;

                f.InsertFood += F_InsertFood;
                f.DeleteFood += F_DeleteFood;
                f.UpdateFood += F_UpdateFood;

                f.InsertCategory += f_InsertCategory;
                f.DeleteCategory += f_DeleteCategory;
                f.UpdateCategory += f_UpdateCategory;
                f.ShowDialog();
            }

            private void F_UpdateFood(object? sender, EventArgs e)
            {
                LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).Id);
                if (lsvBill.Tag != null)
                    ShowBill((lsvBill.Tag as Table).ID);
            }

            private void F_DeleteFood(object? sender, EventArgs e)
            {
                LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).Id);
                if (lsvBill.Tag != null)
                    ShowBill((lsvBill.Tag as Table).ID);
                LoadTable();
            }

            private void F_InsertFood(object? sender, EventArgs e)
            {
                LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).Id);
                if (lsvBill.Tag != null)
                    ShowBill((lsvBill.Tag as Table).ID);
            }

            private void f_UpdateTable(object? sender, EventArgs e)
            {
                LoadTable();
                LoadComboBoxTable(cbSwitchTable);
            }

            private void f_DeleteTable(object? sender, EventArgs e)
            {
                LoadTable();
                LoadComboBoxTable(cbSwitchTable);
            }

            private void f_InsertTable(object? sender, EventArgs e)
            {
                LoadTable();
                LoadComboBoxTable(cbSwitchTable);

            }

            private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                AcountProfileUI f = new AcountProfileUI(LoginAccount);
                f.UpdateAccountEv += f_UpdateAcount;

                f.ShowDialog();
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

        private void f_UpdateAcount(object? sender, EventArgs e)
        {

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
                TableDAO.Instance.SetTableStatusNotEmpty(table.ID);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfor(idBill, idFood, count);
                TableDAO.Instance.SetTableStatusNotEmpty(table.ID);
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
                    ExportToPDF(table.ID,discount,totalPrice,finalTotalPrice);
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    TableDAO.Instance.SetTableStatusEmpty(table.ID);
                    ShowBill(table.ID);
                    LoadTable();


                }
            }

            

        }

        private void SwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID; //lấy ra id table đang chọn
            int id2 = (cbSwitchTable.SelectedItem as Table).ID; //lấy ra id table muốn chuyển bàn

            if (id1 == id2)
            {
                MessageBox.Show("Bàn bị trùng!");
                return;
            }

            string s1 = (lsvBill.Tag as Table).Status;
            string s2 = (cbSwitchTable.SelectedItem as Table).Status;

            if(s1.Equals("Trống")  && s2.Equals("Có người"))
            {
                TableDAO.Instance.SetTableStatusNotEmpty(id1);
                TableDAO.Instance.SetTableStatusEmpty(id2);
            } else if (s1.Equals("Có người") && s2.Equals("Trống"))
            {
                TableDAO.Instance.SetTableStatusNotEmpty(id2);
                TableDAO.Instance.SetTableStatusEmpty(id1);
            } else if (s1.Equals("Trống") && s2.Equals("Trống"))
            {
                MessageBox.Show("Hai bàn đã chọn đều trống!");
                return;
            }
     

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


        private void cbSwitchTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void ExportToPDF(int tableID, int discount, double totalPrice, double finalTotalPrice)
        {
            int idBill = BillDAO.Instance.GetUncheckBillIDBytableID(tableID);
            string folder = "ListBill";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(tableID);

            Document bill = new Document();
            string pdfPath = $"ListBill\\bill{idBill}.pdf";
       
            using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
            {
                PdfWriter.GetInstance(bill, fs);

                bill.Open();

                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12); 


                Paragraph title = new Paragraph("Quán Cà Phê Nhóm 3, Trường Đại học Công Nghiệp Hà Nội", font);
                bill.Add(title);
                bill.Add(new Paragraph("Số 298 Đ. Cầu Diễn, Minh Khai, Bắc Từ Liêm, Hà Nội", font));

                
                bill.Add(new Paragraph("Thời gia vào : " + BillDAO.Instance.GetDateCheckIn(idBill),font));
                bill.Add(new Paragraph("Thời gia ra : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "                Mã hóa đơn : " + idBill,font));


                bill.Add(new Paragraph("-------------------------------------------------------------------------------------------"));


                PdfPTable table = new PdfPTable(4); 
                table.WidthPercentage = 70; 
                table.HorizontalAlignment = Element.ALIGN_LEFT;

                table.AddCell(new PdfPCell(new Phrase("Tên món", font)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = PdfPCell.NO_BORDER });
                table.AddCell(new PdfPCell(new Phrase("Giá", font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });
                table.AddCell(new PdfPCell(new Phrase("Số lượng", font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });
                table.AddCell(new PdfPCell(new Phrase("Thành tiền", font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });

                // Thêm dữ liệu món ăn vào bảng (ẩn viền)
                foreach (Menu item in listBillInfo)
                {
                    table.AddCell(new PdfPCell(new Phrase(item.FoodName, font)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = PdfPCell.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(item.Price.ToString(), font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(item.Count.ToString(), font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(item.TotalPrice.ToString(), font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });
                }

                bill.Add(table);

                bill.Add(new Paragraph("-------------------------------------------------------------------------------------------"));

                // Thêm thông tin tổng tiền và giảm giá (ẩn viền)
                string x = "Tổng tiền:";
                string y = "Giảm Giá:";
                string z = "Thanh Toán:";

                PdfPTable totalsTable = new PdfPTable(2); // 2 cột: mô tả và giá trị
                totalsTable.WidthPercentage = 70;
                totalsTable.HorizontalAlignment = Element.ALIGN_LEFT;

                totalsTable.AddCell(new PdfPCell(new Phrase(x, font)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = PdfPCell.NO_BORDER });
                totalsTable.AddCell(new PdfPCell(new Phrase(totalPrice.ToString(), font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });

                totalsTable.AddCell(new PdfPCell(new Phrase(y, font)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = PdfPCell.NO_BORDER });
                totalsTable.AddCell(new PdfPCell(new Phrase($"{discount}%", font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });

                totalsTable.AddCell(new PdfPCell(new Phrase(z, font)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = PdfPCell.NO_BORDER });
                totalsTable.AddCell(new PdfPCell(new Phrase(finalTotalPrice.ToString(), font)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = PdfPCell.NO_BORDER });

                bill.Add(totalsTable);

                bill.Close();
            }
        }


    }


}
