using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get 
            { 
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
            private set { TableDAO.Instance = value; }
        }

        private TableDAO() { }

        public static int TableWidth = 80;
        public static int TableHeight = 80;

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_GetTableList");

            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tableList.Add(table);

            }


            return tableList;
        }

        public List<Table> GetTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_GetTableList");

            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tableList.Add(table);

            }


            return tableList;
        }


        public void SwitchTable(int id1, int id2)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_SwitchTable @idTable1 , @idTable2", new object[] {id1, id2});
            
        }



        public bool InsertTable(string name)
        {
            string query = $"insert into TableFood(name, status, isActive) values (N'{name}',N'Trống',1 )";

            int data = DataProvider.Instance.ExcuteNonQuery(query);

            return data > 0;
        }

        public bool UpdateTable(int id,string name)
        {
            string query = $"update TableFood set name = N'{name}' where id = {id}";

            int data = DataProvider.Instance.ExcuteNonQuery(query);

            return data > 0;
        }

        public bool DeleteTable(int id)
        {
            string query = $"update TableFood set isActive = 0 where id = {id}";

            int res = DataProvider.Instance.ExcuteNonQuery(query);

            return res > 0;
        }


        public void SetTableStatusNotEmpty(int id)
        {
            DataProvider.Instance.ExcuteQuery("Update TableFood set status = N'Có người' where id = " + id);
        }

        public void SetTableStatusEmpty(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("Update TableFood set status = N'Trống' where id = " + id);

        }
    }
}
