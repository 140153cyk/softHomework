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
                Action action = () =>
                {
                    infoBox.AppendText(url + "\n");
                };
                if (this.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else action();
            };
            crawler.error += (message) =>
            {
                Action action = () =>
                {
                    infoBox.AppendText("ERROR:" + message + "\n");
                };
                if (this.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else action();
                
            };
        }

        private void crawl_Click(object sender, EventArgs e)
        {
            crawler.initCrawler();
            Thread thread = new Thread(()=>crawler.Crawl(crawler.startUrl));
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
