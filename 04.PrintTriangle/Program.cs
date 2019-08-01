using System;

namespace _04.PrintTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintFirstTriangle(n);
            PrintSecondTriangle(n - 1);
        }

        private static void PrintFirstTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
        }

        private static void PrintSecondTriangle(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        
    }
}
