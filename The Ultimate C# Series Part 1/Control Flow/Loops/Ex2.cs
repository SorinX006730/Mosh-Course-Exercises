using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var SumOfNumbers = 0;

            bool Exe = true;
            while (Exe == true)
            {
                Console.Write("Enter a number , if you want to exit enter 'ok' and the programm will finish: ");
                var OptionInput = Console.ReadLine();

                if (OptionInput.ToLower() == "ok")
                    break;

                SumOfNumbers = SumOfNumbers + Convert.ToInt32(OptionInput);
            }
            Console.WriteLine("Sum of all numbers is: " + SumOfNumbers);
            Console.ReadLine();
        }
    }
}