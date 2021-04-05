using System;
using System.Text;

namespace Exercise3Mosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.");
            Console.ReadLine();
            Console.Clear();

            /*[=======================================================]*/

            Console.WriteLine("Image Teller : PORTRAIT // PICTURE");

            Console.Write("Insert the Width : ");
            int Width = (int)ImageDetails.Width;
            Width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the Heigth : ");
            int Heigth = (int)ImageDetails.Heigth;
            Heigth = Convert.ToInt32(Console.ReadLine());

            if (Heigth > Width)
            {
                Console.WriteLine("It is a portrait !");
            }
            else if (Width > Heigth)
            {
                Console.WriteLine("It is a landscape");
            }
            else
            {
                Console.WriteLine("Is nothing !");
            }
        }
    }
}