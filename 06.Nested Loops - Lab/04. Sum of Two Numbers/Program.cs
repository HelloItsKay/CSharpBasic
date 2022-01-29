using System;
using System.Threading.Channels;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magickNumber = int.Parse(Console.ReadLine());
            int count = 0;
            int totalCombinations = 0;
            for (int i = startInterval; i <=endInterval ; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    count++;
                    totalCombinations++;
                    if (i + j == magickNumber)
                    {

                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magickNumber})");
                        return;
                    }


                }
                Console.WriteLine($"{totalCombinations} combinations - neither equals {magickNumber}");
            }


        }
    }
}

