using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());//10464
            double lenghtInMeters= double.Parse(Console.ReadLine());//1500
            double timeInSecondsForOneMeter= double.Parse(Console.ReadLine());//20

            double waterResistanceTime = Math.Floor(lenghtInMeters / 15) * 12.5;//1250
            double timeForThoseMetters = lenghtInMeters * timeInSecondsForOneMeter;

            double totalTime = waterResistanceTime + timeForThoseMetters;

            if (currentRecord>totalTime)
            {
                
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double secondsSlower = totalTime - currentRecord;
                Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
            }
        }
    }
}
