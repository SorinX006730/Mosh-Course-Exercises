using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program which takes two numbers from the console and displays the maximum of the two.");
            Console.ReadLine();
            Console.Clear();

            /*[==============================================]*/

            Console.Write("Insert the first (number) : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the second (number) : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("The [MAX] is : {0}" + FirstNumber);
            }
            else if (SecondNumber > FirstNumber)
            {
                Console.WriteLine("The [MAX] is : " + SecondNumber);
            }
            else
            {
                Console.WriteLine("They are equal // ERROR ");
            }
        }
    }
}