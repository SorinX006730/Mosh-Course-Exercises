using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int CarSpeed;
            int CarSpeedLimit;

            Console.Write("Insert your car speed : ");
            CarSpeed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert your car speed limit : ");
            CarSpeedLimit = Convert.ToInt32(Console.ReadLine());

            if (CarSpeed < CarSpeedLimit)
            {
                Console.Clear();
                Console.WriteLine(" OK OK OK ");
                Console.ReadLine();
            }
            else if (CarSpeed > CarSpeedLimit)
            {
                Console.Clear();
                Console.WriteLine("DEMERIT POINTS CALCULATION");
                Console.ReadKey();
                Console.Clear();

                const int SpeedDemerit = 5;
                int DemeritCalc = (CarSpeed - CarSpeedLimit) / SpeedDemerit;
                if (SpeedDemerit > 12)
                {
                    Console.Clear();
                    Console.WriteLine("LICENSE SUSPENDED");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR");
                Console.ReadLine();
            }
        }
    }
}