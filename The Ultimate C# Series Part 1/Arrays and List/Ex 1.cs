using System;
using System.Collections.Generic;

namespace ListEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListNames = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var NameInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(NameInput))
                    break;
                ListNames.Add(NameInput);
            }

            if (ListNames.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post", ListNames[0], ListNames[1], ListNames.Count - 2);
            }
            else if (ListNames.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", ListNames[0], ListNames[1]);
            }
            else if (ListNames.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", ListNames[0]);
            }
            else
                Console.WriteLine("No one liked your post");
        }
    }
}