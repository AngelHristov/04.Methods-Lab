using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, n));           
        }

        private static string RepeatString(string text, int n)
        {
            string repeatedText = "";
            for (int i = 0; i < n; i++)
            {
                repeatedText += text;
            }
            return repeatedText;
        }
    }
}
