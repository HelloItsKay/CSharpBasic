using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //За лятната ваканция в спикъка със задължителна литература на Жоро има определен брой книги, но Жоро предпочита да играе с приятели навън. Вашата задача е да помогнете на Жоро да изчисли колко часа на ден трябва да отделя, за да прочете необходимата литература, но и да прекарва максимално време навън.
            //1.	Брой страници в текущата книга – цяло число в интервала [1…1000];
            int pageAmount = int.Parse(Console.ReadLine());
            //2.	Страници, които може да прочита за 1 час – реално число в интервала [1.00…1000.00];
            double pagePerHour = double.Parse(Console.ReadLine());
            //3.	Броя на дните, за които трябва да прочете книгата – цяло число в интервала [1…1000];
            int daysToReedBook = int.Parse(Console.ReadLine());
            //4. Calculations 
            //изчисляваме общото време за четене на книгата
            double totalTime = pageAmount / pagePerHour;
                //необходимите часове на ден за четене 
                double hoursPerDay = totalTime / daysToReedBook;

                Console.WriteLine($"{hoursPerDay}");
        }
    }
}
