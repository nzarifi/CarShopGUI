using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> Carlist { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            Carlist = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalcost = 0;
            foreach (var c in ShoppingList)
            {
                totalcost += c.Price;
            }
            ShoppingList.Clear();
            return totalcost;   

        }
    }
}
