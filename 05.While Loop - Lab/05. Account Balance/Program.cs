using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }
                double sum = double.Parse(input);
                if (sum > 0)
                {
                    total += sum;
                    Console.WriteLine($"Increase: {sum:F2}");
                }
                else if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {total:F2}");


        }
    }
}
