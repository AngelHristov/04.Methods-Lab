using System;

namespace _10.MultiplyEvenByOdds
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int sumOdds = SumOfOdds(number);
            int sumEven = SumOfEven(number);
            int multiple = GetMultipleOfEvenAndOdds(sumOdds, sumEven);
            Console.WriteLine(multiple);
        }

        private static int GetMultipleOfEvenAndOdds(int sumOdds, int sumEven)
        {
            return sumEven * sumOdds;
        }

        private static int SumOfEven(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int SumOfOdds(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
