using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double result = Calculate(a, operand, b);
            Console.WriteLine(result);
        }

        private static double Calculate(int a, char operand, int b)
        {
            double result = 0;
            switch (operand)
            {
                case '+': result = a + b;break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
                default:
                    break;
            }
            return result;
        }
    }
}
