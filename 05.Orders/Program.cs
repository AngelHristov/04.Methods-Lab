using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //coffee – 1.50
            //water – 1.00
            //coke – 1.40
            //snacks – 2.00
            string product = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            PrintSum(product, n);
        }

        private static void PrintSum(string product, int n)
        {
            double sum = 0;
            switch (product)
            {
                case "coffee": sum = n * 1.5; break;
                case "water": sum = n * 1.00; break;
                case "coke": sum = n * 1.40; break;
                case "snacks": sum = n * 2.00;break;
                default:
                    break;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
