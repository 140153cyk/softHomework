using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TodoApi.Models
{
    [Serializable]
   public class OrderDetail
    {
        [Key]
        public int DetailID { get; set; }
       
        [ForeignKey("ProductID")]
        public Product product { get; set; }

        public int ProductID { get; set; }
        public int quantity { get; set; }
        public double TotalPrice { get; set; }
        public OrderDetail(Product product,int quantity)
        {
            this.product = product;
            this.quantity = quantity;
            TotalPrice = product.Price * quantity;
        }
        public OrderDetail() { }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   EqualityComparer<Product>.Default.Equals(product, detail.product) &&
                   quantity == detail.quantity;
        }


        public override string ToString()
        {
            return $"Product:{product.ToString()}\nQuantity:{quantity}\n";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(product, quantity, TotalPrice);
        }
    }
}
