using System;

namespace Computer_Room_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int catsNumber = int.Parse(Console.ReadLine());
            int smallCat = 0;
            int bigCats = 0;
            int hugeCats = 0;

            double catsFoodWeight = 0;
            for (int i = 0; i <catsNumber ; i++)
            {
                double catsFood = double.Parse(Console.ReadLine());

                if (catsFood>=100 && catsFood <200)
                {
                    smallCat++;
                }

                if (catsFood >=200 && catsFood < 300)
                {
                    bigCats++;
                }

                if (catsFood>=300 && catsFood<400)
                {
                    hugeCats++;
                }

                catsFoodWeight += catsFood;
            }

            catsFoodWeight /= 1000;

            Console.WriteLine($"Group 1: {smallCat} cats.");
            Console.WriteLine($"Group 2: {bigCats} cats.");
            Console.WriteLine($"Group 3: {hugeCats} cats.");

            Console.WriteLine($"Price for food per day: {(catsFoodWeight*12.45):F2} lv.");
        }
    }
}
