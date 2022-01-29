using System;

namespace _03._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalName = Console.ReadLine();

            switch (animalName)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "snake":
                case "crocodile":
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                    

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
