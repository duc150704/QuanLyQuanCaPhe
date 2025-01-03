﻿using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBillIDBytableID(int id)
        {
            string query = "select * from Bill where idTable = "+ id + " and status = 0";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;// thanh cong
            }
            return -1; // that bai
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("exec USP_InserBill @idTable", new object[] { id });

        }

        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("select max(id) from Bill");
            } catch
            {
                return 1;
            }
        }

        public void CheckOut(int id,int discount, float totalPrice)
        {
            string query = "update Bill set timeCheckOut = getdate(), dateCheckOut = getdate(), status = 1, " + "discount = " + discount + ", totalPrice = " +totalPrice + " where id = " + id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public DataTable LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExcuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] {checkIn, checkOut });
        }

        public DataTable GetRevenueFromDateToDate(DateTime d1, DateTime d2)
        {
            string query = "select sum(totalPrice) from Bill where DateCheckIn >= '" + d1 + "' and DateCheckOut <= '" + d2 + "' and status = 1";

            return DataProvider.Instance.ExcuteQuery(query);

        }

        public string GetDateCheckIn(int idBill)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select FORMAT(DateCheckIn, 'dd/MM/yyyy hh:mm:ss') as [DateCheckIn] from Bill where id =" + idBill);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["DateCheckIn"].ToString();
            }
            else
            {
                return ""; 
            }
        }
    }
}
