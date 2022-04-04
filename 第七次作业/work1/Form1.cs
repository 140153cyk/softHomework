using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work1
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Color color=Color.Black;
        int n ;
        double leng;
         double th1;
         double th2;
         double per1;
         double per2;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void DrawButton_Click(object sender, EventArgs e)
        {
            //clearPanel();
            panel3.Refresh();


            if (int.TryParse(RecurBox.Text,out int result1)&&
            Double.TryParse(LengBox.Text,out double result2)&&
            Double.TryParse(Th1Box.Text,out double result3)&&
            Double.TryParse(Th2Box.Text,out double result4)&&
            Double.TryParse(Per1Box.Text,out double result5)&&
            Double.TryParse(Per2Box.Text,out double result6)) 
            {
                n = result1;
                leng = result2;
                th1 = result3;
                th2 = result4;
                per1 = result5;
                per2 = result6;

                if (graphics == null) graphics = panel3.CreateGraphics();
                drawCayleyTree(n, panel3.Size.Width/2, panel3.Size.Height-80, leng, -Math.PI / 2);

                alert.Text = "提示：参数无误";
            }
            else
            {
                alert.Text = "提示：错误参数";
            }

            

            
           

        }



        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            color = dialog.Color;
        }

        void drawCayleyTree(int n,
        double x0, double y0, double leng, double th)
        {

            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            Pen pen = new Pen(color, 1);
            graphics.DrawLine(pen,(int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}

