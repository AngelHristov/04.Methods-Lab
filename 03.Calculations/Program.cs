using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int numberX = int.Parse(Console.ReadLine());
            int numberY = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                AddNumbers(numberX, numberY);
            }
            else if (command == "multiply")
            {
                MultiplyNumbers(numberX, numberY);
            }
            else if (command == "divide" && numberX > 0)
            {
                DivideNumbers(numberX, numberY);
            }
            else if (command == "subtract")
            {
                SubtractNumbers(numberX, numberY);
            }
        }

        private static void SubtractNumbers(int numberX, int numberY)
        {
            Console.WriteLine(numberX - numberY);
        }

        private static void DivideNumbers(int numberX, int numberY)
        {
            Console.WriteLine(numberX / numberY);
        }

        private static void MultiplyNumbers(int numberX, int numberY)
        {
            Console.WriteLine(numberX * numberY);
        }

        private static void AddNumbers(int numberX, int numberY)
        {
            Console.WriteLine(numberX + numberY);
        }
    }
}
