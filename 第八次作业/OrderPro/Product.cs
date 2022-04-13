using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPro
{
   public class Product
    {
        public static List<Product> products { get; } = new List<Product>();
        public int Id { get; set; }
        public double Price { get; set; }
        public string name { get; set; }

        public Product(int id, double price, string name)
        {
            Id = id;
            Price = price;
            this.name = name;
            Product.products.Add(this);
        }
        public Product() 
        {
            Product.products.Add(this);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
