using QuanLyQuanCAFE.DAO;
using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCAFE
{
    public partial class fAmin : Form
    {
        public fAmin()
        {
            InitializeComponent();
            LoadDateTimePicker();
            LoadListBillByDate(dateTimePicker01.Value, dateTimePicker02.Value);

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
        }

        private void listBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
