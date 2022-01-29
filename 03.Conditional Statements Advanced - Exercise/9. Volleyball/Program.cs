using System;

namespace _9._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holydays = double.Parse(Console.ReadLine());
            double weekendsHeTravel = double.Parse(Console.ReadLine());

            const int totalWeekendsinTheYear = 48;

            
            //saturday games
            double saturdayGames = (48 - weekendsHeTravel)*3/4;
           

            double holydayGames = holydays * 2 / 3;

            double totalGames = saturdayGames + holydayGames+weekendsHeTravel;
            if (yearType=="leap")
            {
                totalGames = totalGames * 1.15;
            }
            else if (yearType=="normal")
            {
                totalGames = totalGames;
            }


            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
