using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            switch (type)
            {
                case "int": PrintGreaterInt(value1, value2); break;
                case "char": PrintGreaterChar(value1, value2); break;
                case "string": PrintGreaterString(value1, value2); break;
                default:
                    break;
            }
        }

        private static void PrintGreaterString(string value1, string value2)
        {
            if (value1.CompareTo(value2) >= 0)
            {
                Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine(value2);
            }
            
        }

        private static void PrintGreaterChar(string value1, string value2)
        {
            char a = char.Parse(value1);
            char b = char.Parse(value2);
            if (a >= b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        private static void PrintGreaterInt(string value1, string value2)
        {
            int a = int.Parse(value1);
            int b = int.Parse(value2);

            if (a >= b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
