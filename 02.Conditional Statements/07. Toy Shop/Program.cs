using System;
using System.Threading;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            //Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни. С парите, които ще спечели иска да отиде на екскурзия. Да се напише програма, която пресмята печалбата от поръчката.
            // Цени на играчките:
            //•	Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.


            //Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена. От спечелените пари Петя трябва да даде 10% за наема на магазина. Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
            // От конзолата се четат 6 реда:
            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]
            //На конзолата се отпечатва:
            //•	Ако парите са достатъчни се отпечатва:
            //o   "Yes! {оставащите пари} lv left."
            //•	Ако парите НЕ са достатъчни се отпечатва:
            // o   "Not enough money! {недостигащите пари} lv needed."

            const double priceOfPuzzle = 2.60;
            const double priceOftalkingDolls = 3;
            const double priceOfteddyBears = 4.10;
            const double priceOfMinnions = 8.20;
            const double priceOfTrucks= 2;
           
            
            double price = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minnions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

           
            
            int countOfToys = (puzzle + talkingDolls + teddyBears + minnions + trucks); 
            
            double MoneyEarned = ((puzzle * priceOfPuzzle) + (talkingDolls * priceOftalkingDolls) + (teddyBears * priceOfteddyBears) + (minnions * priceOfMinnions + trucks * priceOfTrucks));
            double MoneyEarnedDiscount = MoneyEarned - (MoneyEarned * 0.25);
          
            if (countOfToys >= 50)
            {
                if (price < MoneyEarnedDiscount-(MoneyEarnedDiscount*0.10))
                {
                    Console.WriteLine($"Yes! {(MoneyEarnedDiscount - (MoneyEarnedDiscount * 0.10)) - price:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {((MoneyEarnedDiscount - (MoneyEarnedDiscount * 0.10)) - price) * (-1):f2} lv needed."); 
                }
            }
            else
            {
                if (price < MoneyEarned-(MoneyEarned*0.10))
                {
                    Console.WriteLine($"Yes! {(MoneyEarned - (MoneyEarned * 0.10)) - price:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {((MoneyEarned - (MoneyEarned * 0.10)) - price) * (-1):f2} lv needed.");
                }
            }





            

        }
    }
}
