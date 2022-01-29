    using System;

    namespace _02._Password
    {
        class Program
        {
            static void Main(string[] args)
            {
                string username = Console.ReadLine();
                string password = Console.ReadLine();
                string inputMyPassword = Console.ReadLine();
                while (inputMyPassword!=password)
                {
                    inputMyPassword = Console.ReadLine();

                }

                Console.WriteLine($"Welcome {username}!");
            }
        }
    }
