using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
            byte[] tmp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(tmp);

            string data = "";
            foreach (byte item in hashData)
            {
                data += item;
            }

            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[] {userName, data});


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
            byte[] p = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] nP = ASCIIEncoding.ASCII.GetBytes(newPass);

            byte[] hashP = new MD5CryptoServiceProvider().ComputeHash(p);
            byte[] hashNP = new MD5CryptoServiceProvider().ComputeHash(nP);

            string pString = "";
            string nPString = "";
            foreach (byte item in hashP)
            {
                pString += item;
            }
            foreach (byte item in hashNP)
            {
                nPString += item;
            }
            int data = DataProvider.Instance.ExcuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { userName,displayName,pString, nPString});
            return data > 0;

        }
        public bool InsertAccount(string userName, string displayName, int type )
        {
            string query = string.Format("INSERT dbo.Account ( userName, displayName, type ,passWord)VALUES  ( N'{0}', N'{1}', {2}, 33354741122871651676713774147412831195)", userName, displayName, type);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool EditAccount(string userName, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET displayName = N'{1}', type = {2} WHERE userName = N'{0}'", userName, displayName, type);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = string.Format("Delete Account where userName = N'{0}'", userName);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool ResetAccount(string userName)
        {
            string query = string.Format("update Account set passWord = 33354741122871651676713774147412831195 where userName = N'{0}'", userName);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
