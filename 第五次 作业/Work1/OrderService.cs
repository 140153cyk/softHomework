using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work1
{
    class OrderService
    {
        static List<Order> orderList = new List<Order>();
        public static void AddOrder(Order order)
        {
            if (orderList.Contains(order)) throw new ArgumentException("Have the same order!");
            orderList.Add(order);
        }

        public static void DeleteOrder(int id)
        {
            Order order=new Order();
            order.Id = id;

            if(!orderList.Remove(order))throw new ArgumentException("There is no such order");
        }

        public static void ChangeOrder(int id,List<OrderDetail> list)
        {
            selectOrderByID(id).detailList = list;
        }

        public static void ShowAllOrder()
        {
            orderList.ForEach((order) => {
                Console.WriteLine(order);
                Console.WriteLine();
                });
            
        }
        public static IEnumerable<Order> selectOrderByGuest(int accountNum,string name)
        {
            Guest guest = new Guest(accountNum, name);
            var query = from order in orderList where order.OrderGuest.Equals(guest)
                        orderby order.TotalPayment
                        select order;
            return query;
            
        }
    
        public static Order selectOrderByID (int id)
        {
            var query = from order in orderList
                        where order.Id==id
                        orderby order.TotalPayment
                        select order;
            return query.First();
        }

        public static IEnumerable<Order> selectOrderByProduct(Product product)
        {
            var query = from order in orderList
                        where order.GetProducts().Contains(product)
                        orderby order.TotalPayment
                        select order;
            return query;
        }
        public static Order selectOrderByPayment(double payment)
        {
            var query = from order in orderList
                        where order.TotalPayment==payment
                        select order;
            return query.First();
        }

        public static void sortOrder()
        {
            orderList.Sort();
        }
  

        public static void sortOrder(Comparison<Order> func)
        {
            orderList.Sort(func);
        }
    }
}
