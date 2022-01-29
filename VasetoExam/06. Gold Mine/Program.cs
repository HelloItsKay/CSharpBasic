using System;
using System.Threading;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locationNumber = int.Parse(Console.ReadLine());

            double gold = 0;



            for (int i = 0; i < locationNumber; i++)
            {


                double averageGoldPerDay = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                gold = 0;

                for (int j = 0; j < days; j++)
                {
                    double goldGain = double.Parse(Console.ReadLine());
                    gold += goldGain;
                }
                double goldperDay = gold / days * 1.0;

                if (goldperDay > averageGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {goldperDay:F2}.");
                }

                if (goldperDay < averageGoldPerDay)
                {
                    double goldNeed = averageGoldPerDay - (goldperDay);
                    Console.WriteLine($"You need {goldNeed:F2} gold.");
                }



            }
        }
    }
}
