using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            //Мария решава да мине на диета и отива до близкия пазар, за да купи ягоди, банани, портокали и малини. На конзолата се въвежда цената на ягодите в лв./ кг.и количеството на бананите, портокалите, малините и ягодите, които трябва да закупи. Да се напише програма, която пресмята колко пари са ѝ необходими за да плати сметката, като знаете, че:



            //1.Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            double PriceOfStrawberries = double.Parse(Console.ReadLine());
            //2.	Количество на бананите в килограми – реално число в интервала [0.00 … 1 0000.00]
            double AmountOfBananasInKilograms = double.Parse(Console.ReadLine());
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            double AmountOfOrangesInKilograms = double.Parse(Console.ReadLine());
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            double AmountOfRaspberriesInKilograms = double.Parse(Console.ReadLine());
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]
            double AmountOfStrawberriesInKilograms = double.Parse(Console.ReadLine());
           
            
            //•	цената на бананите е с 80 % по - ниска от цената на малините.
            
            // // •	цената на малините е на половина по - ниска от тази на ягодите;
            double PriceOfRaspberries = PriceOfStrawberries/ 2;
            //•	цената на портокалите е с 40 % по - ниска от цената на малините;
            double PriceOfOranges = PriceOfRaspberries -(PriceOfRaspberries * 0.4);
            //•	цената на бананите е с 80% по-ниска от цената на малините.
            double PriceOfBananas = PriceOfRaspberries -(PriceOfRaspberries * 0.8);

            double bill = (PriceOfRaspberries * AmountOfRaspberriesInKilograms) + (PriceOfOranges * AmountOfOrangesInKilograms) + (PriceOfBananas * AmountOfBananasInKilograms)+(PriceOfStrawberries* AmountOfStrawberriesInKilograms);

            
            Console.WriteLine($"{bill:f}");

            


        }
    }
}
