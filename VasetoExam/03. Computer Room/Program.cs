using System;

namespace _03._Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hoursSpend = int.Parse(Console.ReadLine());
            int peopleInGroup = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double pricePerPerson = 0;
            double discount = 0;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    if (dayOrNight=="day")
                    {
                        pricePerPerson = 10.50;
                    }

                    if (dayOrNight == "night")
                    {
                        pricePerPerson = 8.40;
                    }

                    break;
                case "june":
                case "july":
                case "august":
                    if (dayOrNight == "day")
                    {
                        pricePerPerson = 12.60;
                    }

                    if (dayOrNight == "night")
                    {
                        pricePerPerson = 10.20;
                    }

                    break;

            }

            if (peopleInGroup>=4)
            {
                pricePerPerson = pricePerPerson * 0.90;
            }

            if (hoursSpend>=5)
            {
                pricePerPerson = pricePerPerson * 0.50;

            }

            double totalCost = pricePerPerson * peopleInGroup * hoursSpend;

            Console.WriteLine($"Price per person for one hour: {pricePerPerson:F2}");
            Console.WriteLine($"Total cost of the visit: {totalCost:F2}");





        }
    }
}