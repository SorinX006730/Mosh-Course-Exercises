using System;
using System.Collections.Generic;
using System.Text;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;
            else
                return;

            List<int> Numbers = new List<int>();
            foreach (var number in input.Split('-'))
                Numbers.Add(Convert.ToInt32(number));

            List<int> uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in Numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }
    }
}