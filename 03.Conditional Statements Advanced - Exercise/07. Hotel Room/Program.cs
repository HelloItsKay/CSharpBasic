using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const double mayAndOctomberStudioPrise = 50;
            const double mayAndOctomberApartmentPrise = 65;

            const double juneAndSeptemberStudioPrise= 75.20;
            const double juneAndSeptemberApartmentPrise = 68.70;

            const double julyAndAugustStudioPrise = 76;
            const double julyAndAugustApartmentPrise = 77;

            string season = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalMoneyStudio = 0;
            double totalMoneyApartment = 0;


            switch (season)
            {

                case "May":

                    totalMoneyStudio = nights * mayAndOctomberStudioPrise;
                    totalMoneyApartment = nights * mayAndOctomberApartmentPrise;
                    if (nights>7 && nights<14)

                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;

                    }

                    else if (nights>14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.30;
                    }

                    break;

                case "October":

                    totalMoneyStudio = nights * mayAndOctomberStudioPrise;
                    totalMoneyApartment = nights * mayAndOctomberApartmentPrise;
                    if (nights>7 && nights<14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;
                    }
                    else if (nights>14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.30;
                    }

                    break;
                case "June":
                    totalMoneyStudio = nights * juneAndSeptemberStudioPrise;
                    totalMoneyApartment = nights * juneAndSeptemberApartmentPrise;
                    if (nights>14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.20;
                    }
                    break;

                case "September":
                    totalMoneyStudio = nights * juneAndSeptemberStudioPrise;
                    totalMoneyApartment = nights * juneAndSeptemberApartmentPrise;
                    if (nights>14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.20;

                    }
                    break;
                case "July":
                    totalMoneyStudio = nights * julyAndAugustStudioPrise;
                    totalMoneyApartment = nights * julyAndAugustApartmentPrise;

                    break;

                case "August":
                    totalMoneyStudio = nights * julyAndAugustStudioPrise;
                    totalMoneyApartment = nights * julyAndAugustApartmentPrise;

                    break;
            }
            if (nights>14)
            {
                totalMoneyApartment -= totalMoneyApartment * 0.10;
            }
            Console.WriteLine($"Apartment: {totalMoneyApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyStudio:f2} lv.");




        }
    }
}
