using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = Console.ReadLine();
            int count = 0;
            int sumPrimeNumbers = 0;
            int sumNonPrimeNumbers = 0;
            while (stop != "stop")
            {

                int number = int.Parse(stop);   
                

                if (number != 2)
                {
                    if (number % 2 == 0)
                    {
                        count++;
                    }
                }


                if (number != 3)
                {
                    if ( number % 3 == 0)
                    {
                        count++;
                    }
                }

                if (number / 1 == number)
                {
                    count++;
                }

                if (number < 0)
                {
                    Console.WriteLine($"Number is negative.");
                    count = 0;
                }

                if (count > 1)
                {
                    sumNonPrimeNumbers += number;
                }
                else if(count<=1 && number >0)
                {
                    sumPrimeNumbers += number;
                }



                count = 0;
                stop = Console.ReadLine();


            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbers}");
        }
    }
}
