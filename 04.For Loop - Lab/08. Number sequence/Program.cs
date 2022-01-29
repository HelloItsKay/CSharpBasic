using System;
using System.Net.NetworkInformation;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            int countOfNumbers = int.Parse(Console.ReadLine());



            for (int i = 0; i < countOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;  
                }
                if (number > max)
                {
                    max = number; 
                }




            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
