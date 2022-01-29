using System;

namespace Conditional_Statements___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int seconds = firstTime + secondTime + thirdTime;
            int minutes = seconds / 60;
            int secondsAfter = seconds % 60;
            
                Console.WriteLine($"{minutes}:{secondsAfter:d2}");

        }
    }
}
