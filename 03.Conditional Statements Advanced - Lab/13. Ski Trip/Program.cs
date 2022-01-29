using System;
using System.Linq.Expressions;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
           string review = Console.ReadLine();

            double roomPrise = 0;
            double totalPrise = 0;
            double discount = 0;





            switch (room)

            {
                case "room for one person":
                    roomPrise = 18.00;
                    
                    break;

                case "apartment":
                    roomPrise = 25.00;
                    if (days<10)
                    {
                        discount = 30;
                    }
                    else if (days<=10 || days<=15)
                    {
                        discount = 35;
                    }
                    else if (days>15)
                    {
                        discount = 50;
                    }
                    break;

                case "president apartment":
                    roomPrise = 35.00;

                    if (days < 10)
                    {
                        discount = 10;
                    }
                    else if (days <= 10 && days <= 15)
                    {
                        discount = 15;
                    }
                    else if (days > 15)
                    {
                        discount = 20;
                    }
                    break;
            }
           

            totalPrise = (days-1) * roomPrise;
            totalPrise= totalPrise - (totalPrise * discount/100);
            

            if (review == "positive")
            { 
                totalPrise *= 1.25;
            }
            else
            {
                totalPrise *= 0.9;
            }
            Console.WriteLine($"{totalPrise:F2}");

        }
    }
}
