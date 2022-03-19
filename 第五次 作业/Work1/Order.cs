using System;
using System.Collections.Generic;
using System.Text;

namespace Work1
{
    class Order:IComparable
    {
        public List<OrderDetail> detailList { get; set; } = new List<OrderDetail>();
        public Guest OrderGuest { get; set; }
        public DateTime OrderTime { get; set; }
        public double TotalPayment { get; set; }
        public int Id { get; set; }

        public Order(Guest orderGuest,int id)
        {
            OrderGuest = orderGuest;
            OrderTime = DateTime.Now;
            Id = id;
            TotalPayment = 0;
            //添加明细列表,计算总金额未做
        }
        public Order() { }
        public void AddDetail(Product product,int quantity)
        {
            OrderDetail detail = new OrderDetail(product, quantity);
            if (detailList.Contains(detail)) throw new ArgumentException("Have the same detail!");
            detailList.Add(detail);
            TotalPayment += detail.TotalPrice;
        }

        public List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();
            detailList.ForEach((detail) => list.Add(detail.product));
            return list;
        }


        int IComparable.CompareTo(object obj)
        {
            Order order = obj as Order;
            if (order == null) throw new System.ArgumentException();
            return Id-order.Id;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   Id == order.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Guest:{OrderGuest.Name} ID:{Id} Time: {OrderTime.Hour}:{OrderTime.Minute}:{OrderTime.Second}\n");
            foreach(OrderDetail detail in detailList)
            {
                sb.Append(detail.ToString());
            }
            sb.Append($"TotalPayment:{TotalPayment}");
            return sb.ToString();
        }
    }
}
