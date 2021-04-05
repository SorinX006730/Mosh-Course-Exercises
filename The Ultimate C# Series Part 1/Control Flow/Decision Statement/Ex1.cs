using System;
using System.Text;
using System.Linq;


namespace MoshExercise1
{
    /*public enum Numbers
    {
        FirstNumber = 1,
        SecondNumber = 2
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOne = (int)Numbers.FirstNumber;
            int NumberTwo = (int)Numbers.SecondNumber;


            Console.WriteLine("Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display Valid on the console. Otherwise, display Invalid. (This logic is used a lot in applications where values entered into input boxes need to be validated.)");
            Console.ReadLine();
            Console.Clear();

            /*[=====================================================]*/

            Console.WriteLine("Insert a number between " + NumberOne + " and " + NumberTwo);

            Console.Write("Insert a (number) : ");
            int NumberOption = Convert.ToInt32(Console.ReadLine());

            if (NumberOption > 1 && NumberOption < 10)
            {
                Console.WriteLine("--VALID NUMBER--");
                Console.ReadLine();
            }
            else if (NumberOption > 1 && NumberOption > 10)
            {
                Console.WriteLine("--INVALID NUMBER--");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("error ... INSERTED SOMETHING WRONG");
                Console.ReadLine();
            }
        }
    }
}