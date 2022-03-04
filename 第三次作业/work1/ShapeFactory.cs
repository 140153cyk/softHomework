using System;
using System.Collections.Generic;
using System.Text;

namespace work1
{
    class ShapeFactory
    {
        public Square GetSquare(float s)
        {
            Shape product = new Square(s);
            if (product.IsValid()) return (Square)product;
            return null;
        }
        public Rectangle GetRectangle(float l, float h)
        {
            Shape product = new Rectangle(l, h);
            if (product.IsValid()) return (Rectangle)product;
            return null;
        }

        public Triangle GetTriangle(float a, float b, float c)
        {
            Shape product = new Triangle(a, b, c);
            if (product.IsValid()) return (Triangle)product;
            return null;
        }

        public void ShowRadomShape()
        {
            Shape product;
            Random r = new Random();
            int kind = r.Next(0, 3);
            switch (kind)
            {
                case 0:
                    do
                        product = new Rectangle((float)(10 * r.NextDouble()), (float)(10 * r.NextDouble()));
                    while (product == null);
                    product.ShowInfor();
                    break;
                case 1:
                    do
                        product = new Square((float)(10 * r.NextDouble()));
                    while (product == null);
                    product.ShowInfor();
                    break;
                case 2:
                    do
                        product = new Triangle((float)(10 * r.NextDouble()), (float)(10 * r.NextDouble()), (float)(10 * r.NextDouble()));
                    while (product == null);
                    product.ShowInfor();
                    break;
            }
        }
    }
}
