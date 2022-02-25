using System;
using System.Collections.Generic;

namespace work1
{
    class Program
    { 
        static HashSet<int> set = new HashSet<int>();
        static bool IsPrimeNumber(int num)
        {
            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static void DivideNum(int num)
        {
           
            for(int i=2; i <= num; i++)
            {
                if (!IsPrimeNumber(i)||num%i!=0) continue;

                set.Add(i);

                while (num % i == 0) num /= i;

            }

        }

        static int UserInput()
        {
            int result = 0;
            Console.WriteLine("Please enter your number");
            if (int.TryParse(Console.ReadLine(), out result))
            {
                return result;
            }
            else return UserInput();
        }
        static void Main(string[] args)
        {
            int num = UserInput();
            DivideNum(num);
            foreach(int x in set)
            {
                Console.Write(x);
                Console.Write(" ");
            }

            
        }
    }
}
