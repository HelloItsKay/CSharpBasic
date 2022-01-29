using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakeslises = length * width;
            int slices = 0;



            while (cakeslises>slices)
            {
                string Stop = Console.ReadLine();
                if (Stop=="STOP")
                {
                    int slicesLeft = cakeslises - slices;
                    Console.WriteLine($"{slicesLeft} pieces are left.");
                    break;
                }

                int slisecTaken = int.Parse(Stop);
                slices += slisecTaken;
            }

            if (cakeslises<slices)
            {
                int slicesNeed = slices - cakeslises;
            Console.WriteLine($"No more cake left! You need {slicesNeed} pieces more.");
            }
            
        }
    }
}
