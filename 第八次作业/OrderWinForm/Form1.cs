using OrderPro;
using System;
using System.Windows.Forms;

namespace OrderWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initService();

            orderBindingSource.DataSource = OrderService.orderList;

        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
        public void initService()
        {
            Guest guest1 = new Guest(1001, "Sean");
            Guest guest2 = new Guest(1002, "Bark");

            Product apple = new Product(101, 2.00, "苹果");
            Product banana = new Product(102, 1.00, "香蕉");
            Product orange = new Product(103, 3.50, "橘子");

            Order order1 = new Order(guest1, 001);
            order1.AddDetail(apple, 2);
            order1.AddDetail(orange, 1);
            OrderService.AddOrder(order1);



            Order order2 = new Order(guest2, 002);
            order2.AddDetail(apple, 1);
            order2.AddDetail(banana, 2);
            order2.AddDetail(orange, 2);
            OrderService.AddOrder(order2);

            Order order3 = new Order(guest1, 003);
            order3.AddDetail(apple, 3);
            order3.AddDetail(orange, 2);
            OrderService.AddOrder(order3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order deleteOrder = (Order)orderBindingSource.Current;
            OrderService.DeleteOrder(deleteOrder.Id);
            orderGridView.DataSource = null;
            orderGridView.DataSource = orderBindingSource;          
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            int queryWay = listQueryWay.SelectedIndex;
            String para = textQuery.Text;
            switch (queryWay)
            {
                case 0:
                    foreach(Guest guest in Guest.guests)
                    {
                        if (guest.Name.Equals(para))
                        {
                            orderBindingSource.DataSource= OrderService.selectOrderByGuest(guest);
                        }
                    }
                    break;
                case 1:
                    if(Int32.TryParse(para,out int id))
                    {
                        orderBindingSource.DataSource = OrderService.selectOrderByID(id);
                    }
                    break;
                case 2:
                    foreach(Product product in Product.products)
                    {
                        if (product.name.Equals(para))
                        {
                            orderBindingSource.DataSource = OrderService.selectOrderByProduct(product);
                        }
                    }
                    break;
                case 3:
                    if(Double.TryParse(para,out double payment))
                    {
                        orderBindingSource.DataSource = OrderService.selectOrderByPayment(payment);
                    }
                    break;
                default:
                    break;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ManageOrderForm newForm = new ManageOrderForm();
            newForm.ShowDialog();
            if (newForm.newOrder != null) OrderService.orderList.Add(newForm.newOrder);
            orderGridView.DataSource = null;
            orderGridView.DataSource = orderBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order pre = (Order)orderBindingSource.Current;
            ManageOrderForm manageForm = new ManageOrderForm(pre);
           
            manageForm.ShowDialog();
            orderGridView.DataSource = null;
            orderGridView.DataSource = orderBindingSource;

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
