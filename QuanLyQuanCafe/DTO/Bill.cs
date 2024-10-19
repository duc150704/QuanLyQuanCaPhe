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

        public int ID { get => iD; set => iD = value; }
        public DateTime? DataCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckout, int status)
        {
            this.ID = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckout;
            this.status = status;
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
        }
        
    }
}
