using System;

namespace SquareArea_03
{
    class Program
    {
        static void Main(string[] args)

        {

            //Да се напише конзолна програма, която въвежда цяло число
            //a и пресмята лицето на квадрат със страна  a
           
           int sideOfSquare = int.Parse(Console.ReadLine());
            int squareArea = sideOfSquare * sideOfSquare;
           Console.WriteLine($"{squareArea}");
        }
    }
}
