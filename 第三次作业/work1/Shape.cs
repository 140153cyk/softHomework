using System;
using System.Collections.Generic;
using System.Text;

namespace work1
{
    public abstract class Shape
    {
       abstract public bool IsValid();
      abstract  public float GetArea();

        public void ShowInfor()
        {
            Console.WriteLine(GetType().Name+":");
            Console.WriteLine("valid:" + IsValid() + " ");
            if (IsValid())
            {
                Console.WriteLine("Area:" + GetArea());
            }
            Console.WriteLine();
        }
    }
}
