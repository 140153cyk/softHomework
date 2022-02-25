using System;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] notPrime = new bool[100];

            notPrime[0] = true;
            for(int i = 2; i < 10; i++)
            {
                if (notPrime[i - 1]) continue;
                for(int j = 2*i; j < 100; j += i)
                {
                    notPrime[j - 1] = true;
                }
            }
            for(int i = 0; i < 100; i++)
            {
                if (!notPrime[i])
                {
                    Console.Write(i + 1 + " ");
                }
            }
        }
    }
}
