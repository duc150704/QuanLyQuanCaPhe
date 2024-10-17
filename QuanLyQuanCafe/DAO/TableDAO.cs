using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks;

namespace QuanlyQuanCafe.Dao
{
	public class TableDAO
	{
		private static TableDAO instance;

		public static TableDAO Instance
		{ get { if (instance == null) instance = new TableDAO();  return TableDAO.instance; }
			private set { TableDAO.instance = value; }
		}

		public static int TableWidth = 90;
		public static int TableHeight = 90;

		private TableDAO() { }
		public List<Table> LoadTableList()
		{
			List<Table> tableList = new List<Table>;
			DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetTableList");
			foreach (DataRow item in data.Rows) 
			{
				Table table = new Table(item);
				tableList.Add(table);
			}

			return tableList;
		}
	}
}
