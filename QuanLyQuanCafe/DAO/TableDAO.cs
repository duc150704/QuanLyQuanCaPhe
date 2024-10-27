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

    }
}
