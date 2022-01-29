using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < countOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;

                }
                else
                {
                    oddSum += currentNumber;
                }


            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {

                Console.WriteLine("No");
                Console.WriteLine("Diff= " +(Math.Abs(oddSum - evenSum)));
            }




        }

    }
}
