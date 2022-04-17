using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crawler;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SimpleCrawler crawler;
        public Form1()
        {
            InitializeComponent();
            crawler = new SimpleCrawler();
            startUrlBox.DataBindings.Add("Text", crawler,"startUrl");

            crawler.addUrl += (url) =>
            {
                infoBox.AppendText(url + "\n");
            };
            crawler.error += (message) =>
            {
                infoBox.AppendText("ERROR:" + message + "\n");
            };
        }

        private void crawl_Click(object sender, EventArgs e)
        {
            crawler.Crawl();
        }
    }
}
