using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            // Божидара разполага с няколко къщи на Черноморието и желае да озелени дворовете
            //на някои от тях, катопо този начин създаде уютна обстановка и комфорт на гостите 
            //си, като за целта е наела фирма.Напишете програма, която изчислява необходимите
            //средства, които Божидара ще трябва да заплати на фирмата изпълнител на проекта.
            //Цената на един кв. м.е 7.61лв със ДДС.Тъй като нейният двор е доста
            //голям, фирмата изпълнител предлага 18 % отстъпка от крайната цена.

            double landscaping = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double price = landscaping * pricePerSquareMeter;
            double discount = price*0.18;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is:{finalPrice} lv.");
            Console.WriteLine($"The discount is:{discount} lv.");





        }
    }
}
