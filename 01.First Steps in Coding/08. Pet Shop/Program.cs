using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 2 реда:
            //1.Броят на кучетата – цяло число в интервала[0… 100]
            //2.Броят на останалите животни - цяло число в интервала[0… 100]
         
            int countOfDogs = int.Parse(Console.ReadLine());
            int countOfOtherAnimals = int.Parse(Console.ReadLine());
            //3.Цена за една опаковка храна за кучета = 2.50
            double dogFood = 2.50;
            //4. Цена за една опаковка храна за дуго вид  животно = 4.00
            double otherAnimalsFood = 4.00;
            //5.Крайната сума
            double sum = (countOfDogs * dogFood) + (countOfOtherAnimals * otherAnimalsFood);
            //6 принтиране на цена 
        
            Console.WriteLine($"{sum} lv. ");

        }
    }
}
