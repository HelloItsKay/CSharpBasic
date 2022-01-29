using System;

namespace _06._Charity_Campaign_hard
{
    class Program
    {
        static void Main(string[] args)
        {
            //В сладкарница се провежда благотворителна кампания за събиране на средства, в която могат да се включат сладкари от цялата страна.Първоначално прочитаме от конзолата броя на дните, в които тече кампанията и броя на сладкарите, които ще се включат.След това на отделни редове получаваме количеството на тортите, гофретите и палачинките, които ще бъдат приготвени от един сладкар за един ден. Трябва да се има предвид следния ценоразпис:
            //•	Торта - 45 лв.
            //•	Гофрета - 5.80 лв.
            //•	Палачинка – 3.20 лв.
            // 1 / 8 от крайната сума ще бъде използвана за покриване на разходите за продуктите по време на кампанията. Да се напише програма, която изчислява сумата, която е събрана в края на кампанията.

            //1.Броят на дните, в които тече кампанията – цяло число в интервала [0 … 365]
            
            int numberOfDays = int.Parse(Console.ReadLine());

            //2.	Броят на сладкарите – цяло число в интервала [0 … 1000]
            
            int numberOfConfectioner = int.Parse(Console.ReadLine());
            //3.	Броят на тортите – цяло число в интервала [0… 2000]
            int numberOfCakes = int.Parse(Console.ReadLine());
            //4.	Броят на гофретите – цяло число в интервала [0 … 2000]
            int numberOfWaffles = int.Parse(Console.ReadLine());
            //5.Броят на палачинките – цяло число в интервала [0 … 2000]
            int numberOfPanCakes = int.Parse(Console.ReadLine());
            //-------------------------------------------------------------------------------
           
            double pricePerCake = 45;
            double PricePerWaffle = 5.80;
            double PricePerPanCake = 3.20;
            //Обща сума за един ден
            double profitPerDay = numberOfConfectioner*((numberOfCakes * pricePerCake) + (numberOfWaffles * PricePerWaffle) + (numberOfPanCakes * PricePerPanCake));
            //Сума събрана от цялата кампания
            double profitForTheCampain = profitPerDay * numberOfDays;
            //Сума след покриване на разходите
            double TotalEarnings = profitForTheCampain - (profitForTheCampain * 1 / 8);
                Console.WriteLine($"{TotalEarnings}");



        }
    }
}
