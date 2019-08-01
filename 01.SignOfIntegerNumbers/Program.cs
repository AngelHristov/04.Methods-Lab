﻿using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintSignOfInt(number);
        }

        private static void PrintSignOfInt(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
