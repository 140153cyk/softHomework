using OrderPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace OrderWinForm
{
    public partial class Form1 : Form
    {
        private List<OrderDetail> detailList = new List<OrderDetail>();

        public Form1()
        {
            InitializeComponent();

            using(var db=new OrderContext())
            {
                orderBindingSource.DataSource = db.Orders.Include("detailList").Include("OrderGuest")
                        .Include(o => o.detailList.Select((d) => d.product)).ToList();
            }
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Order deleteOrder = (Order)orderBindingSource.Current;
            using(var db=new OrderContext())
            {
                var delete = db.Orders.Include("detailList")
                    .FirstOrDefault(o => o.Id == deleteOrder.Id);
                db.Orders.Remove(delete);
                db.SaveChanges();
                orderBindingSource.DataSource = db.Orders.Include("detailList").Include("OrderGuest")
                        .Include(o => o.detailList.Select((d) => d.product)).ToList();
            }
            orderGridView.DataSource = null;
            orderGridView.DataSource = orderBindingSource;          
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            int queryWay = listQueryWay.SelectedIndex;
            String para = textQuery.Text;
            using (var db = new OrderContext())
            {
                switch (queryWay)
                {
                    case 0:
                         Guest guest = db.Guests.Where((g) => g.Name == para).FirstOrDefault();
                        if (guest != null)
                        {
                             orderBindingSource.DataSource = null;
                             orderBindingSource.DataSource = db.Orders.Include("detailList").Include("OrderGuest")
                             .Include(o => o.detailList.Select((d) => d.product)).Where(o=>o.OrderGuest.AccountNum==guest.AccountNum).ToList();
                            orderDetailBindingSource.DataMember = "detailList";
                        }
                               
                        
                        break;
                    case 1:
                        if (Int32.TryParse(para, out int id))
                        {
                            orderBindingSource.DataSource = null;
                            orderBindingSource.DataSource = db.Orders.Include("detailList").Include("OrderGuest")
                            .Include(o => o.detailList.Select((d) => d.product)).Where(o => o.Id== id).ToList();
                            orderDetailBindingSource.DataMember = "detailList";
                        }
                        break;
                    case 2:
                        Product product = db.Products.Where((p) => p.name == para).FirstOrDefault();
                        List<OrderDetail> detailList = db.Details.Where(d => d.product.name==product.name).ToList();
                        List<int> orderList = new List<int>(); 
                        foreach(OrderDetail detail in detailList)
                        {
                            if (!orderList.Contains(detail.OrderId))
                                orderList.Add(detail.OrderId);

                        }
                        orderBindingSource.DataSource = null;
                        orderBindingSource.DataSource = db.Orders.Include("detailList").Include("OrderGuest")
                        .Include(o => o.detailList.Select((d) => d.product)).Where(o=>orderList.Contains(o.Id)).ToList();
                        orderDetailBindingSource.DataMember = "detailList";
                        break;
                    case 3:
                        if (Double.TryParse(para, out double payment))
                        {
                            orderBindingSource.DataSource = null;
                            orderBindingSource.DataSource = db.Orders.Include("detailList").Include("OrderGuest")
                            .Include(o => o.detailList.Select((d) => d.product)).Where(o => o.TotalPayment==payment).ToList();
                            orderDetailBindingSource.DataMember = "detailList";
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ManageOrderForm newForm = new ManageOrderForm();
            newForm.ShowDialog();
            using(var db=new OrderContext())
            {
                Order newOrder = newForm.newOrder;
            if (newOrder != null) db.Orders.Add(newOrder);
            foreach(OrderDetail detail in newOrder.detailList)
             {
                    db.Products.Attach(detail.product);
             }
             db.Guests.Attach(newOrder.OrderGuest);
            
            db.SaveChanges();
            orderBindingSource.DataSource = db.Orders.Include("detailList").Include("OrderGuest")
                    .Include(o => o.detailList.Select((d) => d.product)).ToList();
            orderGridView.DataSource = orderBindingSource;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {   using (var db = new OrderContext())
            {
                Order pre = db.Orders.Include("detailList").Include("OrderGuest")
                    .Include(o => o.detailList.Select((d) => d.product)).Where(o=>o.Id==((Order)orderBindingSource.Current).Id).FirstOrDefault();
                db.Entry(pre).State = EntityState.Unchanged;
                ManageOrderForm manageForm = new ManageOrderForm(pre);
                manageForm.ShowDialog();
                db.Entry(pre).State = EntityState.Modified;

                db.SaveChanges();
                orderBindingSource.DataSource = db.Orders.Include("detailList").Include("OrderGuest")
                        .Include(o => o.detailList.Select((d) => d.product)).ToList();
                orderGridView.DataSource = orderBindingSource;

            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            OrderService.Import(fileDialog.FileName);
            orderBindingSource.DataSource = OrderService.orderList;
            orderGridView.DataSource = null;
            orderGridView.DataSource = orderBindingSource;

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.ShowDialog();
            OrderService.Export(fileDialog.FileName);
        }
    }
}
