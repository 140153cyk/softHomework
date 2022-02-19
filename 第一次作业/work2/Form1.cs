using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work2
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0,result=0;
        int o=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
             x = Int32.Parse(tb.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
             y = Int32.Parse(tb.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            o = lb.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (o)
            {
                case 0:result = x + y;break;
                case 1:result = x - y;break;
                case 2:result = x * y;break;
                case 3:result = x / y;break;
            }
            label2.Text = "" + result;
        }
    }
}
