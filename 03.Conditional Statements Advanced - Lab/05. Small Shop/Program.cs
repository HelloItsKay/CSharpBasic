using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string stock = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;
            if (city == "Sofia")
            {
                if (stock == "coffee")
                {
                    price = amount * 0.50;
                }
                else if (stock == "water")
                {
                    price = amount * 0.80;
                }
                else if (stock == "beer")
                {
                    price = amount * 1.20;
                }
                else if (stock == "sweets")
                {
                    price = amount * 1.45;
                }
                else if (stock=="peanuts")
                {
                    price = amount * 1.60;
                }
            }

            if (city == "Plovdiv")
            {
                if (stock == "coffee")
                {
                    price = amount * 0.40;
                }
                else if (stock == "water")
                {
                    price = amount * 0.70;
                }
                else if (stock == "beer")
                {
                    price = amount * 1.15;
                }
                else if (stock == "sweets")
                {
                    price = amount * 1.30;
                }
                else if (stock == "peanuts")
                {
                    price = amount * 1.50;
                }
            }

            if (city == "Varna")
            {
                if (stock == "coffee")
                {
                    price = amount * 0.45;
                }
                else if (stock == "water")
                {
                    price = amount * 0.70;
                }
                else if (stock == "beer")
                {
                    price = amount * 1.10;
                }
                else if (stock == "sweets")
                {
                    price = amount * 1.35;
                }
                else if (stock == "peanuts")
                {
                    price = amount * 1.55;
                }
            }
            Console.WriteLine(price);
        }
    }
}
