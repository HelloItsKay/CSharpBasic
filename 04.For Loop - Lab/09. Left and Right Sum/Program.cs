using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int rightNumber = 0;
            int leftNumber = 0;
            for (int i = 0; i < countOfNumbers; i++)
            {

                 leftNumber = leftNumber+int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < countOfNumbers; i++)
            {

                 rightNumber = rightNumber + int.Parse(Console.ReadLine());

            }
            if (leftNumber == rightNumber)
                Console.WriteLine("Yes, sum = " + leftNumber);
            else
            {
                int diff = Math.Abs(rightNumber - leftNumber);
                Console.WriteLine("No, diff = "+ diff);
            }
                    
        }

    }
}

