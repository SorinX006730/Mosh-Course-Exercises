using System;
using System.Collections.Generic;
using System.Text;

namespace FilesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var InputNumbers = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in InputNumbers.Split('-'))
                numbers.Add(Convert.ToInt32(number));
            numbers.Sort();

            bool isConsecutive = true;
            for (i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
    }
}