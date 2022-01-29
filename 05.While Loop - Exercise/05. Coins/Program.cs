using System;
using System.Threading;


namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            change = 100 * change;
            int coins = 0;

            while (change > 0)
            {
                if (change > 200)
                {
                    coins++;
                    change -= 200;
                }

                else if (change >= 100)
                {
                    coins++;
                    change -= 100;
                }

                else if (change >= 50)
                {
                    coins++;
                    change -= 50;
                }

                else if (change >= 20)
                {
                    coins++;
                    change -= 20;
                }

                else if (change >= 10)
                {
                    coins++;
                    change -= 10;
                }

                else if (change >= 05)
                {
                    coins++;
                    change -= 05;
                }

                else if (change >= 02)
                {
                    coins++;
                    change -= 02;
                }

                else if (change >= 01)
                {
                    coins++;
                    change -= 01;
                }
            }

            Console.WriteLine(coins);
            

        }
    }
}
