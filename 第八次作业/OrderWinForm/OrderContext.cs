using OrderPro;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWinForm
{
    public class OrderContext:DbContext
    {
        public OrderContext() : base("Orderbase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());            
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
    }
}
