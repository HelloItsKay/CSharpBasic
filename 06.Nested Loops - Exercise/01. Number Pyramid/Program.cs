using System;
using System.Threading.Channels;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int rows = 1;
            int currNumb = 1;

            while (number>=currNumb)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write($"{currNumb}");
                    currNumb++;
                    if (currNumb>number)
                    {
                        break;
                    }

                }
                Console.WriteLine();
                rows++;

            }

        }
    }
}
