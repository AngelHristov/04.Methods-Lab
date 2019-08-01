using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = MathPower(num, power);
            Console.WriteLine(result);
        }

        private static double MathPower(double num, int power)
        {
            double result = 0d;
            result = Math.Pow(num, power);
           
            return result;
        }
    }
}
