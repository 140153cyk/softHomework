using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.Models
{
   public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string name { get; set; }

        public Product(int id, double price, string name)
        {
            Id = id;
            Price = price;
            this.name = name;
        }
        public Product() { }

        public override string ToString()
        {
            return $"ID:{Id} Price:{Price} Name:{name}";
        }
    }
}
