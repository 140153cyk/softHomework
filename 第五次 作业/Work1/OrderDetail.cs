using System;
using System.Collections.Generic;
using System.Text;

namespace Work1
{
    class OrderDetail
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
