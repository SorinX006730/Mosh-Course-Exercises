using System;

namespace ListEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name ? ");
            var NameInput = Console.ReadLine();

            var array = new char[NameInput.Length];
            for (var i = NameInput.Length; i > 0; i--)
                array[NameInput.Length - i] = NameInput[i - 1];

            var ReversedName = new string(array);
            Console.WriteLine("Reversed name: " + ReversedName);
        }
    }
}