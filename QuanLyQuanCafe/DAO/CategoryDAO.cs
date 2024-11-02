﻿using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from FoodCategory";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);

            }
            return list;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT dbo.FoodCategory ( name)VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory( string name)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}' WHERE id = {3}", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(string name)
        {
            BillInfoDAO.Instance.DeleteBillInfoByCategoryID(name);

            string query = string.Format("Delete Food where id = {0}", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }

}
