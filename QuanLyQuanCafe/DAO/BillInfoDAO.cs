using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        { get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
           private set => BillInfoDAO.instance = value; 
        }
        
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from BillInfo where idBill = " + id);


            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
            
        }

        public void DeleteBillInfoByCategoryID(string name)
        {
            DataProvider.Instance.ExcuteQuery("delete dbo.BillInfo WHERE name = " + name);
        }
        public void InsertBillInfor(int idBill, int idFood , int count)
        {
            DataProvider.Instance.ExcuteNonQuery("USP_InsertBillInfo  @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }


    }

    
         
}
