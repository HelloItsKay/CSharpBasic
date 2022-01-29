using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {


            string trip = Console.ReadLine();
            double totalSavings = 0;
            while (trip != "End")
            {
                double prize = double.Parse(Console.ReadLine());

                while (prize > totalSavings)
                {
                    double savings = double.Parse(Console.ReadLine());
                    totalSavings += savings;
                }
                Console.WriteLine($"Going to {trip}!");
                totalSavings = 0;
                trip = Console.ReadLine();
            }




        }
    }
}