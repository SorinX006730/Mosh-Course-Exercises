using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a time (EX : 23:00, with a ':' between");
            string TimeInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(TimeInput))
            {
                Console.WriteLine("-- INVALID TIME --");
                return;
            }

            var ComponentsSpliting = TimeInput.Split(':');
            if (ComponentsSpliting.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(ComponentsSpliting[0]);
                var minute = Convert.ToInt32(ComponentsSpliting[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("The time is good");
                else
                    Console.WriteLine("-- INVALID TIME --");
            }
            catch (Exception)
            {
                Console.WriteLine("--  INVALID TIME -- ");
            }
        }
    }
}