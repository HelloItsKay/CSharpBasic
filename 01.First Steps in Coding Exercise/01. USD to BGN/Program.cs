using System;

namespace First_Steps_in_Coding_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма за конвертиране на щатски долари (USD) в български лева (BGN). Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.

            //1.1.	Създайте променливата usd, която приема като вход от конзолата реално число.
            const double usdCourse = 1.79549;
            
            double dolars = double.Parse(Console.ReadLine());
           // 2.Изчислете конвертирането на щатските долари към българските лева и закръглете резултата до втория знак след десетичната запетая.
            double bgn = usdCourse * dolars;

            //3.Принтирайте получените български лева, като форматирате резултата до 2 цифри след десетичната запетая(:F2).


            Console.WriteLine($"{bgn:f2}");

        }

        
            
        

    }
}
