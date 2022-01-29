using System;
using System.Xml.Schema;

namespace _01._Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double fuelLiters = double.Parse(Console.ReadLine());

            int totaDistance = 768800;

            double timeInBothWays = (totaDistance*1.0 / averageSpeed);

            double totalTime = timeInBothWays + 3;
            double totalFuelConsumption = fuelLiters * totaDistance / 100;

            Console.WriteLine(Math.Ceiling(totalTime));
            Console.WriteLine(totalFuelConsumption);



        }
    }
}
