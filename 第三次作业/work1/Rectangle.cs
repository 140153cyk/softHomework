using System;
using System.Collections.Generic;
using System.Text;

namespace work1
{
    class Rectangle:Shape
    {
        float length;
        float height;

        public float Length
        {
            get=>length;           
            set => length = value;
        }

        public float Height
        {
            get => height;
            set => height = value;
        }

        public Rectangle(float l,float h)
        {
            length = l;
            height = h;
        }
       override public bool IsValid() {
            return true;
        }

        override public float GetArea() {
            return length * height;
        }


    }
}
