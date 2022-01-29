using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());


            int freeSpace = width * length * height;
            int boxSpace = 0;
            while (freeSpace >= boxSpace)
            {

                string done = Console.ReadLine();
                int spaceLeft = freeSpace - boxSpace;
                if (done == "Done")
                {

                    Console.WriteLine($"{spaceLeft} Cubic meters left.");
                    return;
                }
                int box = int.Parse(done);
                boxSpace += box;




                int spaceNeeded = boxSpace - freeSpace;
                if (freeSpace < boxSpace)
                {
                    Console.WriteLine($"No more free space! You need {spaceNeeded} Cubic meters more.");
                }
            }


        }
    }
}
