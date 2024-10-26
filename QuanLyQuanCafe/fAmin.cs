﻿using QuanLyQuanCAFE.DAO;
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
    public partial class fAmin : Form
    {
        public fAmin()
        {
            InitializeComponent();
            LoadDateTimePicker();
            LoadListBillByDate(dateTimePicker01.Value, dateTimePicker02.Value);
            ShowRevenue(dateTimePicker01.Value,dateTimePicker02.Value);
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
    }
}
