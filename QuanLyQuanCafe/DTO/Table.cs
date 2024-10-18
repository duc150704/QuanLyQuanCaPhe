using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DTO
{
    public class Table
    {
        private string name;
        private int iD;
        private string status;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name { get => name; set => name = value; }
      
        public string Status { get => status; set => status = value; }

        public Table(int id, string name, string status)
        {
            this.iD = id;
            this.name = name;
            this.status = status;
        }


        public Table(DataRow row) 
        {
            this.ID = (int)row["ID"];
            this.name = (string)row["Name"];
            this.status = (string)row["status"];
        }
    }
}
