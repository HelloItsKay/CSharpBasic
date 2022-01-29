    using System;

namespace _06._Salary
{
    class Program
    {
        static void Main()
        {

            
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string tab = Console.ReadLine();

                switch (tab)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }

                if (salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }

                
            }

            Console.WriteLine(salary);
        }
    }
}
