using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);
            list.add(5);
            int sum=0;
            int min = int.MaxValue;
            int max = int.MinValue;
            list.ForEach((m) => {
                Console.Write(m + " ");
                sum += m;
                min=Math.Min(min,m);
                max = Math.Max(max, m);
            });
            Console.WriteLine();
            Console.WriteLine("Max value is "+max);
            Console.WriteLine("Min value is " + min);
            Console.WriteLine("Sum is " + sum);
        }
    }
}
