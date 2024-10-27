using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        { get 
            {
                if(instance == null)
                    instance = new AccountDAO();
                return instance;
            }
          private set => instance = value; 
        }

        private AccountDAO() { }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("select  UserName, DisplayName,Type from Account");
        }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[] {userName, passWord});
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data =  DataProvider.Instance.ExcuteQuery("select * from Account where UserName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int data = DataProvider.Instance.ExcuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { userName,displayName,pass, newPass});
            return data > 0;

        }
       
    }
}
