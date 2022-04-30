using OrderPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWinForm
{
    public partial class ManageOrderForm : Form
    {
       public Order newOrder { get; set; }
        public ManageOrderForm()
        {

            InitializeComponent();
            newOrder = new Order();
            using(var db=new OrderContext())
            {
                productBindingSource.DataSource = db.Products.ToList();
                guestBindingSource.DataSource = db.Guests.ToList();
            }
            orderBindingSource.DataSource = newOrder.detailList;
            newOrder.OrderTime = DateTime.Now;
            
        }
        public ManageOrderForm(Order order):this()
        {
            newOrder = order;
            orderBindingSource.DataSource = newOrder.detailList;
            guestBox.DataBindings.Add("SelectedItem", newOrder, "OrderGuest");
            newOrder.OrderGuest = Guest.guests[0];
        }
        



        private void detailAddButton_Click(object sender, EventArgs e)
        {
            Product product=(Product)productComboBox.SelectedItem;
            if(Int32.TryParse(quantityTextBox.Text,out int quantity))
            {
                newOrder.AddDetail(product, quantity);
                orderBindingSource.DataSource = null;
                orderBindingSource.DataSource = newOrder.detailList;
                dataGridView1.DataSource = orderBindingSource;
            }
        }

        private void detailDeleteButton_Click(object sender, EventArgs e)
        {
            OrderDetail detail=(OrderDetail)orderBindingSource.Current;
            newOrder.deleteDetail(detail);
            orderBindingSource.DataSource = null;
            orderBindingSource.DataSource = newOrder.detailList;
            dataGridView1.DataSource = orderBindingSource;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();           
        }
    }
}
