using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            while (number % 2 == 1)
            {
                Console.WriteLine("Please write an even number.");
                number = Math.Abs(int.Parse(Console.ReadLine()));
            }
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is: {number}");
            }
        }
    }
}