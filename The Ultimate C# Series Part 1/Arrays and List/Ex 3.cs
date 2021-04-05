using System;
using System.Collections.Generic;

namespace ListEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool StartExe = true;
            List<int> Numbers = new List<int>();

            while (Numbers.Count < 5)
            {
                Console.Write("Enter 5 numbers :");
                int NumbersInput = Convert.ToInt32(Console.ReadLine());
                if (Numbers.Contains(NumbersInput))
                {
                    Console.WriteLine("You already entered this " + NumbersInput);
                    continue;
                }
                Numbers.Add(NumbersInput);
            }

            Numbers.Sort();

            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}