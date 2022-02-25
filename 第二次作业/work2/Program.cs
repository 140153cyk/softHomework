using System;
using System.Collections.Generic;

namespace work2
{
    class Program
    {
        static List<int> UserInput()
        {
            Console.WriteLine("Please enter your numbers");
            String s = Console.ReadLine();
            String[] strings = s.Split(" ");

            List<int> list = new List<int>();
            foreach(string str in strings)
            {
                if (!int.TryParse(str, out int result)) return UserInput();
                list.Add(result);
            }
            return list;


            
        }
        static void Main(string[] args)
        {
            List<int> list = UserInput();

            int max=int.MinValue, min=int.MaxValue,  sum=0;
            double ave;
            foreach(int i in list)
            {
                max = Math.Max(max, i);
                min = Math.Min(min, i);
                sum += i;
            }
            ave = (double)sum / list.Count;

            Console.WriteLine("max value is " + max);
            Console.WriteLine("min value is " + min);
            Console.WriteLine("sum is " + sum);
            Console.WriteLine("average value is " + ave);
            

        }
    }
}
