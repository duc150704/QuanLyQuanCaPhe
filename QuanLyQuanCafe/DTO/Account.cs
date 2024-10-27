using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DTO
{
    public class Account
    {
        public Account(DataRow row) 
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = (int)row["Type"];
        }

        public Account(string userName, string displayName, int type, string password = null) 
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = password;
            this.Type = type;
        }

        private string userName;
        private string password;
        private string displayName;
        private int type;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
    }
}
