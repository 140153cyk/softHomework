using System;
using System.Collections.Generic;

namespace work4
{
    class Program
    {
       static bool IsSuchMatrix(int[][] matrix, int m,int n)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (!map.TryGetValue(i-j,out int value)) map.Add(i - j, matrix[i][j]);
                    else if (matrix[i][j] != value) return false;                  
                }
            }
            return true;
        }

        static int[][] UserInput(out int m,out int n)
        {
            Console.WriteLine("Please enter your matrix ending with #");
            string s = Console.ReadLine();
            m = 0;
            n = 0;
            int[][] matrix= new int[10][];
            while (s != "#")
            {
                string[] strings = s.Split(" ");
                n = strings.Length;
                int[] nums = new int[n];
                for(int i = 0; i < n; i++)
                {
                    if (!int.TryParse(strings[i], out nums[i])) return UserInput(out m,out n);
                    
                }
                matrix[m] = nums;
                m++;
                s = Console.ReadLine();

            }
            return matrix;
        }
        static void Main(string[] args)
        {
            int[][] matrix = UserInput(out int m, out int n);
            Console.WriteLine(IsSuchMatrix(matrix, m, n));
        }
    }
}
