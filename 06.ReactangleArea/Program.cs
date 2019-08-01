using System;

namespace _06.ReactangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double area = ReactangleArea(a, b);
            Console.WriteLine(area);
        }

        private static double ReactangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
