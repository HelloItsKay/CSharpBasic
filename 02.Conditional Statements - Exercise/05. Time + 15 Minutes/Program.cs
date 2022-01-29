using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            

            int totalMinutes = minutes + 15;

            if (totalMinutes >= 60)
            {
                hours += 1;
                minutes = totalMinutes % 60;
            }
            else
            {
                minutes = totalMinutes;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
          
            


            Console.WriteLine($"{hours}:{minutes:d2}");
        }
        
    }
}
