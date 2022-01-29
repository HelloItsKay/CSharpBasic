using System;
using System.Linq.Expressions;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetOfTheGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermans = int.Parse(Console.ReadLine());

            const int rentOfShipSpring = 3000;
            const int rentOfShipSummer = 4200;
            const int rentOfShipAutumn = 4200;
            const int rentOfShipWinter = 2600;

            int rentOfShip = 0;

            double  discount = 0;
            double extraDiscount = 0;

            if (numberOfFishermans <= 6)
            {
                discount = 0.90;
            }
            else if (numberOfFishermans > 7 && numberOfFishermans <= 11)
            {
                discount = 0.85;
            }
            else
            {
                discount = 0.75;
            }

            
            
             if (numberOfFishermans % 2 == 0 && season!="Autumn")
       
            {
                extraDiscount = 0.95;
            }

           

            





            switch (season)
            {
                case "Spring":
                    rentOfShip = rentOfShipSpring;
                    break;

                case "Summer":
                    rentOfShip = rentOfShipSummer;
                    break;

                case "Autumn":
                    rentOfShip = rentOfShipAutumn;
                    break;
                case "Winter":
                    rentOfShip = rentOfShipWinter;
                    break;
         
            }
            double price = 0;

            switch (extraDiscount)
            {
                case 0:
                    price = rentOfShip*discount;
                    break;
                default:
                    price = (rentOfShip * discount) * extraDiscount;
                    break;
            }





            

            if (price >budgetOfTheGroup)
            {
                double priceNeed = price - budgetOfTheGroup;
                Console.WriteLine($"Not enough money! You need {priceNeed:F2} leva.");
            }
            else
            {
                double priceLeft = budgetOfTheGroup - price;
                Console.WriteLine($"Yes! You have {priceLeft:F2} leva left.");
            }


        }

    }
}
