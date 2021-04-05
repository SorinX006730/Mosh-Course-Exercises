using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int count = 0;

            for (i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("The numbers that are divisional to 3 are = {0}", count);
        }
    }
}








