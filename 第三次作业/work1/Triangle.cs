using System;
using System.Collections.Generic;
using System.Text;

namespace work1
{
    class Triangle:Shape
    {
        float a;
        float b;
        float c;

        float A
        {
            get => a;
            set => a = value;
        }
        float B
        {
            get => b;
            set => b = value;
        }
        float C
        {
            get => c;
            set => c = value;
        }

        public Triangle(float  a,float  b,float  c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        override public bool IsValid()
        {
            return !(a + b <= c || a + c <= b || b + c <= a);
        }

        override public float GetArea()
        {
            float p = (a + b + c) / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
