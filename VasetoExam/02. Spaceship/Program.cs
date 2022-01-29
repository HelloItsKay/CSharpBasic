using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());
            double averageAstronautsHigh = double.Parse(Console.ReadLine());

            double spaceCraftVolume = width * length * high;
            double roomVolume = (averageAstronautsHigh + 0.40) * 2 * 2;

            double countOfAstonauts = spaceCraftVolume / roomVolume;

            if (countOfAstonauts > 3 && countOfAstonauts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(countOfAstonauts)}.");
            }
            if (countOfAstonauts < 3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            if (countOfAstonauts > 10)
            {
                Console.WriteLine($"The spacecraft is too big.");
            }

        }
    }
}
