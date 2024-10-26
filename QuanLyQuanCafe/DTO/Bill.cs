using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DTO
{
    public class Bill
    {
        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;
        private int discount;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckout, int status, int discount)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckout;
            this.Status = status;
            this.Discount = discount;
        }


        public Bill(DataRow row) 
        {
            this.ID = (int)row["id"];
            this.dateCheckIn = (DateTime?)row["dateCheckIn"];

            var dateCheckOutTmp = row["dateCheckOut"];
            if (dateCheckOutTmp.ToString() != "")
            {
                this.dateCheckOut = (DateTime?)dateCheckOutTmp;
            }

            
            this.status = (int)row["status"];

            if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }
        
    }
}
