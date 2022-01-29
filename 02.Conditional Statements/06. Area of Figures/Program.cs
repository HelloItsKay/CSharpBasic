using System;
using System.Net.NetworkInformation;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            string square = "square";
            string rectangle = "rectangle";
            string circle = "circle";
            string triangle = "triangle";

            if (shape == square)
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                double SquareArea = sideOfSquare * sideOfSquare;
                Console.WriteLine($"{SquareArea:f3}");

            }
            else if (shape == rectangle)
            {
                double sideOfRectangle = double.Parse(Console.ReadLine());
                double secondSideOfRectangle = double.Parse(Console.ReadLine());

                double rectangleArea = sideOfRectangle * secondSideOfRectangle;
                Console.WriteLine($"{rectangleArea:f3}");
            }
            else if (shape == circle)
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = (Math.PI * (radius*radius));
                Console.WriteLine($"{circleArea:f3}");

            }
            else if (shape == triangle)

            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double triangleArea = (sideOfTriangle * h) / 2;
                Console.WriteLine($"{triangleArea:f3}");

            }
            

        }
    }
}
