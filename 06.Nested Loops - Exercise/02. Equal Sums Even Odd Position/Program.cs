﻿using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                int currNumb = i;
                int oddSum = 0;
                int evenSum = 0;
                int count = 0;
                while (currNumb != 0)
                {
                    int digit = currNumb % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currNumb = currNumb / 10;
                    count++;

                }



                if (oddSum==evenSum)
                {
                    Console.Write($"{i} ");
                }

            }

        }

    }
}