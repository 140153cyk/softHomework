using System;
using System.Collections.Generic;
using System.Text;

namespace work1
{
    class Square:Rectangle
    {
        float s;
        
        public float S
        {
            get => s;
            set => s = value;
        }
        public Square(float s) : base(s, s) { }

        public override bool IsValid()
        {
            return Length==Height;
        }

    }
}
