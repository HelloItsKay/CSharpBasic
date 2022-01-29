using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras= int.Parse(Console.ReadLine());
            double clothForOneExtra= double.Parse(Console.ReadLine());

            double priceForCloths = extras * clothForOneExtra;

            double decor = budget * 0.10;

            if (extras > 150)
            {
                double discount = priceForCloths * 0.10;
                priceForCloths -= discount;
            }
            double totalMoney = decor + priceForCloths;

            if (totalMoney<=budget)

            {
                double moneyLeft = budget-totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                double totalMoneyNeeded = totalMoney - budget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMoneyNeeded:f2} leva more.");
            }


          
        }
    }
}
