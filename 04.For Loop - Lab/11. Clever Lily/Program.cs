using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            double wasingMachinePrise = double.Parse(Console.ReadLine());

            double ToysPrise = double.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int brotherStolenMoney = 0;

            for (int i = 1; i <= liliAge; i++)
            {


                if (i % 2 == 0)
                {
                    money += 10 * (i / 2);
                    brotherStolenMoney += 1;
                }
                else
                {
                    toys += 1;
                }
            }

            double totalMoney = money + toys * ToysPrise - brotherStolenMoney;

            double moneyNeed = wasingMachinePrise - totalMoney;
            double moneyLeft = totalMoney - wasingMachinePrise;
            if (totalMoney > wasingMachinePrise)
            {

                Console.WriteLine($"Yes! {moneyLeft:F2}");
            }
            else
            {
                Console.WriteLine($"No! {moneyNeed:F2}");
            }

        }
    }
}
