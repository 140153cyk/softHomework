using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an operand");
            int x=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another operand");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please choose an operator");
            String o = Console.ReadLine();
            int result;
            switch (o)
            {
                case "+":result = x + y;break;
                case "-":result = x - y;break;
                case "*":result = x * y;break;
                case "/":result = x / y;break;
                default:result = 0;break;
            }

            Console.WriteLine("result is {0}", result);
            Console.ReadLine();
        }
    }
}
