using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DTO
{
    public class Menu
    {
        public Menu(string foodName, int count, float price, float totalPrice = 0) 
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.totalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["quantity"];
            this.Price = (float)Convert.ToDouble(row["price"]);
            this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
