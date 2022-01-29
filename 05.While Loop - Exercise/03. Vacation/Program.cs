using System;
using System.Threading;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForHoliday = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int countDays = 0;
            int spendDaysCounter = 0;

            while (moneyForHoliday > availableMoney)
            {

                countDays++;
                string spendOrSave = Console.ReadLine();
                double amountSavedOrSpend = double.Parse(Console.ReadLine());

                switch (spendOrSave)
                {
                    case "spend":

                        availableMoney -= amountSavedOrSpend;

                        if (availableMoney < 0)
                        {
                            availableMoney = 0;
                        }
                        spendDaysCounter++;
                        break;

                    case "save":
                        spendDaysCounter = 0;
                        availableMoney += amountSavedOrSpend;
                        break;
                }

                if (spendDaysCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countDays);
                    return;
                }

                if (moneyForHoliday <= availableMoney)
                {
                    Console.WriteLine($"You saved the money for {countDays} days.");
                }

            }


        }
    }
}
