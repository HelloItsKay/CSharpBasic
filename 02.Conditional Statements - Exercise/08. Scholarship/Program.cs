using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            //Изискване за социална стипендия - доход на член от семейството по-малък от минималната работна заплата и успех над 4.5. Размер на социалната стипендия - 35% от минималната работна заплата
            //. Изискване за стипендия за отличен успех - успех над 5.5, включително. Размер на стипендията за отличен успех - успехът на ученика, умножен по коефициент 25.
            double socialScolarship = Math.Floor(minimalWage * 0.35);
            double exelentScolarship =Math.Floor( averageSuccess * 25);


            if (income>=minimalWage&&averageSuccess>=5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {exelentScolarship} BGN");
            }
            else if (income>=minimalWage&&averageSuccess<5.5)
            {
                Console.WriteLine("You cannot get a scholarship!"); 
            }
            else if (income<minimalWage&&averageSuccess>=5.5&&socialScolarship<=exelentScolarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {exelentScolarship} BGN");
            }
            else if (income<minimalWage&&averageSuccess>4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            }
            else if (income<minimalWage&&averageSuccess<=4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }








                


            //if (income <= minimalWage & averageSuccess >= 4.50)

            //{
            //    Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            //}

            //else if (averageSuccess>5.50)
            //{
            //    Console.WriteLine($"You get a scholarship for excellent results {exelentScolarship} BGN");
            //}
            //else if (income <= minimalWage & averageSuccess >= 5.50)
            //{
            //    if (exelentScolarship > socialScolarship)
            //    {
            //        Console.WriteLine($"You get a scholarship for excellent results {exelentScolarship} BGN");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("You cannot get a scholarship!");
            //}
        }
    }
}
