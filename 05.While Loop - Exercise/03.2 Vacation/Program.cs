using System;
using System.Threading;


public class Vacation
{
    static void Main(string[] args)
    {


        double moneyForHoliday = double.Parse(Console.ReadLine());
        double availableMoney = double.Parse(Console.ReadLine());
        int countSpendDays = 0;
        int countDays = 0;


        while (moneyForHoliday>availableMoney)
        {
            countDays++;
            string saveOrSpend = Console.ReadLine();
            double amountOfSaveOrSpend = double.Parse(Console.ReadLine());

            switch (saveOrSpend)
            {
                case "save":
                    availableMoney += amountOfSaveOrSpend;
                    countSpendDays = 0;
                    break;

                case "spend":
                    availableMoney -= amountOfSaveOrSpend;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }

                    countSpendDays++;
                    break;
            }
        
            if (countSpendDays == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(countDays);
                break;
            }
            if (availableMoney >= moneyForHoliday)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
        }
    }
}