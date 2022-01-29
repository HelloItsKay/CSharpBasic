using System;

namespace _03.Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double speedCount = double.Parse(Console.ReadLine());

                if (speedCount <= 10)
                {
                    Console.WriteLine("slow");
                }
                else if (speedCount <= 50)
                {
                    Console.WriteLine("average");
                }
                else if (speedCount <= 150)
                {
                    Console.WriteLine("fast");
                }
                else if (speedCount <= 1000)
                {
                    Console.WriteLine("ultra fast");
                }
                else 
                {
                    Console.WriteLine("extremely fast");
                }





            }
        }
    }
}
