using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double pricePerFlower = 0;
            double discount = 0;

           

            switch (kindOfFlower)
            {
                case "Roses":
                    pricePerFlower = 5;
                    if (numberOfFlowers > 80)
                    {
                        discount = 0.9;
                    }


                    break;

                case "Dahlias":
                    pricePerFlower = 3.80;

                    if (numberOfFlowers > 90)
                    {
                        discount = 0.85;
                    }

                    break;

                case "Tulips":
                    pricePerFlower = 2.80;

                    if (numberOfFlowers > 80)
                    {
                        discount = 0.85;
                    }

                    break;

                case "Narcissus":
                    pricePerFlower = 3;
                    if (numberOfFlowers < 120)
                    {
                        discount = 1.15;
                    }

                    break;

                case "Gladiolus":
                    pricePerFlower = 2.50;
                    if (numberOfFlowers < 80)
                    {
                        discount = 1.2;
                    }


                    break;


            }
            double finalPrice = pricePerFlower * numberOfFlowers;
            double finalPriceDiscount = 0;



            switch (discount)
            {
                case 0:
                    finalPriceDiscount = finalPrice;
                    break;
                default:
                    finalPriceDiscount = finalPrice * discount;
                    break;
            }

            if (finalPriceDiscount > budget)
            {
                double priceNeed = finalPriceDiscount - budget;
                Console.WriteLine($"Not enough money, you need {priceNeed:F2} leva more.");
            }
            else
            {
                double priceLeft = budget - finalPriceDiscount;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {kindOfFlower} and {priceLeft:F2} leva left.");
            }

        }
    }
}
