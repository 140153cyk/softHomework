using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderPro
{
   public class OrderService
    {


        public static List<Order> orderList { get; set; } = new List<Order>();
        public static void AddOrder(Order order)
        {
            if (order == null) throw new ArgumentException("It's a null order");
            if (orderList.Contains(order)) throw new ArgumentException("Have the same order!");
            orderList.Add(order);
        }
        public static void ClearOrder()
        {
            orderList = new List<Order>();
        }

        public static void DeleteOrder(int id)
        {
            Order order=new Order();
            order.Id = id;

            if(!orderList.Remove(order))throw new ArgumentException("There is no such order");
        }

        public static void ChangeOrder(int id,Order order)
        {
            if (order == null) throw new ArgumentException("It's a null order");
            if (order.Id != id) throw new ApplicationException("Replaced order has a different id");
            DeleteOrder(id);
            AddOrder(order);
            

            //传Order
        }

        public static void ShowAllOrder()
        {
            orderList.ForEach((order) => {
                Console.WriteLine(order);
                Console.WriteLine();
                });
            
        }
       
        public static IEnumerable<Order> selectOrderByGuest(Guest guest)
        {
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
            return query.FirstOrDefault();//查不到时返回null
        }

        public static IEnumerable<Order> selectOrderByProduct(Product product)
        {
            var query = from order in orderList
                        where order.GetProducts().Contains(product) //order.detailList.Exists(d=>d.Product.Equals(product));
                        orderby order.TotalPayment
                        select order;
            return query;
        }
        public static Order selectOrderByPayment(double payment)
        {
            var query = from order in orderList
                        where order.TotalPayment==payment
                        select order;
            return query.FirstOrDefault();
        }

        public static void sortOrder()
        {
            orderList.Sort();
        }
  

        public static void sortOrder(Comparison<Order> func)
        {
            orderList.Sort(func);
        }

        public static void Export(String path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fs, orderList);
            }
        }

        public static void Import(String path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                orderList = (List<Order>)serializer.Deserialize(fs);
            }
        }
    }
}
