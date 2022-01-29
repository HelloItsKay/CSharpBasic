using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0;

            switch (typeProjection)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    
                    price = 5;
                    break;
                
            }
            double filanPrice = rows * columns * price;
            Console.WriteLine($"{filanPrice:F2} leva");

        }
    }
}
