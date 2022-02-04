using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Car()
        {
            Make = "Nothing";
            Model = "Nothing";
            Price = 0.00M;

        }
        public Car(string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }

        // To print c from carlist properly
        override public string ToString()
        {
            return "Make:" + Make + " Model " + Model + " Price: $" + Price;
        }
    }
}
