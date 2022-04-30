using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Work1;

namespace OrderServiceTest
{
    [TestClass]
    public class ServiceTests
    {
        Guest guest1 = new Guest(1001, "Sean");
        Guest guest2 = new Guest(1002, "Bark");

        Product apple = new Product(101, 2.00, "Æ»¹û");
        Product banana = new Product(102, 1.00, "Ïã½¶");
        Product orange = new Product(103, 3.50, "éÙ×Ó");

        Order order1, order2, order3,order4;

        public ServiceTests()
        {
            order1 = new Order(guest1, 001);
            order1.AddDetail(apple, 2);
            order1.AddDetail(orange, 1);

            order2 = new Order(guest2, 002);
            order2.AddDetail(apple, 1);
            order2.AddDetail(banana, 2);
            order2.AddDetail(orange, 2);


            order3 = new Order(guest1, 003);
            order3.AddDetail(apple, 3);
            order3.AddDetail(orange, 2);

            order4 = new Order(guest2, 004);
            order4.AddDetail(apple, 3);
            order4.AddDetail(banana, 2);

        }

        [TestInitialize]
        public void TestInit()
        {
            OrderService.ClearOrder();
            OrderService.AddOrder(order1);
            OrderService.AddOrder(order2);
            OrderService.AddOrder(order3);
        }

        [TestMethod]
        public void AddOrderTest1()
        {
            OrderService.AddOrder(order4);
            Assert.IsTrue(OrderService.selectOrderByID(4) != null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddOrderTest2()
        {
            OrderService.AddOrder(null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddOrderTest3()
        {
            OrderService.AddOrder(order1);
        }

        [TestMethod]
        public void DeleteOrderTest1()
        {
            OrderService.DeleteOrder(1);
            Assert.IsTrue(OrderService.selectOrderByID(1) == null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteOrderTest2()
        {
            OrderService.DeleteOrder(4);
        }
        [TestMethod]
        public void ChangeOrderTest1()
        {
            Order order5 = new Order(guest1,1);
            OrderService.ChangeOrder(1, order5);

            Assert.AreEqual(OrderService.selectOrderByID(1), order5);
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void ChangeOrderTest2()
        {
            Order order5 = new Order(guest1, 1);
            OrderService.ChangeOrder(5, order5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChangeOrderTest3()
        {
            OrderService.ChangeOrder(1, null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChangeOrderTest4()
        {
            Order order5 = new Order(guest1, 4);
            OrderService.ChangeOrder(4, order5);
        }
        [TestMethod]
        public void SelectOrderByGuestTest1()
        {
            Order result = OrderService.selectOrderByGuest(1002, "Bark").FirstOrDefault();
            Assert.AreEqual(result, order2);
        }

        [TestMethod]
        public void SelecOrderByGuestTest2()
        {
            IEnumerable<Order> order= OrderService.selectOrderByGuest(1003, "Combat");
            Assert.IsNull(order.FirstOrDefault());
        }
        [TestMethod]
        public void SelectOrderByIDTest1()
        {
            Order result = OrderService.selectOrderByID(1);
            Assert.AreEqual(result, order1);
        }
        [TestMethod]
        public void SelectOrderByIDTest2()
        {
            Order result = OrderService.selectOrderByID(4);
            Assert.IsNull(result);
        }
        [TestMethod]
        public void SelctOrderByProductTest1()
        {
            Order result = OrderService.selectOrderByProduct(banana).FirstOrDefault();
            Assert.AreEqual(result, order2);
        }

        [TestMethod]
        public void SelctOrderByProductTest2()
        {
            IEnumerable<Order> result = OrderService.selectOrderByProduct(apple);
            List<Order> list = new List<Order>();
            list.Add(order1);
            list.Add(order2);
            list.Add(order3);
            foreach(Order o in result)
            {
                Assert.IsTrue(list.Contains(o));
                list.Remove(o);
            }
            Assert.IsTrue(list.Count == 0);           
        }
        [TestMethod]
        public void ClearOrderTest()
        {
            OrderService.ClearOrder();
            Assert.AreEqual(OrderService.GetOrders().Count(), 0);
        }
        [TestMethod]
        public void ExportAndImportTest()
        {
            OrderService.Export("D:\\demo.txt");
            OrderService.ClearOrder();
            List<Order> list = new List<Order>();
            list.Add(order1);
            list.Add(order2);
            list.Add(order3);
            OrderService.Import("D:\\demo.txt");
            foreach (Order o in OrderService.GetOrders())
            {
                Assert.IsTrue(list.Contains(o));
                list.Remove(o);
            }
            Assert.IsTrue(list.Count == 0);
        }
    }
}
