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
       public Order newOrder { get; set; } = new Order();
        public ManageOrderForm()
        {

            InitializeComponent();
            

            productBindingSource.DataSource = Product.products;
            orderBindingSource.DataSource = newOrder.detailList;
            guestBindingSource.DataSource = Guest.guests;
            

            newOrder.OrderTime = DateTime.Now;
            newOrder.Id = OrderService.orderList.Count + 1;
            guestBox.DataBindings.Add("SelectedItem", newOrder, "OrderGuest");

            newOrder.OrderGuest = Guest.guests[0];

        }
        public ManageOrderForm(Order order):this()
        {
            newOrder = order;
            orderBindingSource.DataSource = newOrder.detailList;
        }
        



        private void detailAddButton_Click(object sender, EventArgs e)
        {
            Product product=(Product)productComboBox.SelectedItem;
            if(Int32.TryParse(quantityTextBox.Text,out int quantity))
            {
                newOrder.AddDetail(product, quantity);
                orderBindingSource.DataSource = null;
                orderBindingSource.DataSource = newOrder.detailList;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = orderBindingSource;
            }
        }

        private void detailDeleteButton_Click(object sender, EventArgs e)
        {
            OrderDetail detail=(OrderDetail)orderBindingSource.Current;
            newOrder.deleteDetail(detail);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orderBindingSource;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           
        }


    }
}
