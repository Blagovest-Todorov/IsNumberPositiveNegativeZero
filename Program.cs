using System;

namespace TestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SignChecker(num);
            
        }

        private static void SignChecker(int number)
        {
            string sign = null;

            if (number > 0)
            {
                sign = "positive";
            }
            else if (number < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }

            Console.WriteLine($"The number {number} is {sign}.");

        }
    }
}
