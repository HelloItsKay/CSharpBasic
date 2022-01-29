using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Напишете програма, която изчислява каква сума ще получите в края на депозитния период при определен лихвен процент. Използвайте следната формула: сума =    депозирана сума + срок на депозита *((депозирана сума* годишен лихвен процент ) / 12)
            //1.	Депозирана сума – реално число в интервала [100.00 … 10000.00];
            double depositAmount = double.Parse(Console.ReadLine());
            //2.	Срок на депозита(в месеци) – цяло число в интервала [1…12];
            int depositTermMonths = int.Parse(Console.ReadLine());
            //3.	Годишен лихвен процент – реално число в интервала [0.00 …100.00];
            double DepositInterestRateYear = double.Parse(Console.ReadLine());

            // 4 calculations 
            //изчисляваме натрупаната лихва
            double depositAccruedInterest = (depositAmount * DepositInterestRateYear) / 100;
            //изчисляваме лихвата за 1 месец
            double interestForOneMonth = (depositAccruedInterest/ 12);
            //общата сума 
            double totalAmount = (depositAmount+(depositTermMonths)*interestForOneMonth);

             Console.WriteLine($"{totalAmount}");



        }
    }
}
