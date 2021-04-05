using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter commoa separated numbers: ");
            var InputNumbers = Console.ReadLine();

            var numbers = InputNumbers.Split(',');
            var MaxMethod = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > MaxMethod)
                    MaxMethod = number;
            }

            Console.WriteLine("The max is " + MaxMethod);


        }
    }
}