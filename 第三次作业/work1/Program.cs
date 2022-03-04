using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            for(int i = 0; i<10; i++)
            {
                factory.ShowRadomShape();
            }


        }
    }
}
