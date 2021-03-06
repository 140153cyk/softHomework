using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPro
{
    [Serializable]
   public class OrderDetail
    {
        public Product product { get; set; }
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
            int hashCode = 1963471142;
            hashCode = hashCode * -1521134295 + EqualityComparer<Product>.Default.GetHashCode(product);
            hashCode = hashCode * -1521134295 + quantity.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            return hashCode;
        }
    }
}
