using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var NumberOption = Convert.ToInt32(Console.ReadLine());

            var FactorialIndex = 1;
            for (var i = 1; i <= NumberOption; i++)
                FactorialIndex *= i;

            Console.WriteLine("{0} != {1}", NumberOption, FactorialIndex);
        }
    }
}