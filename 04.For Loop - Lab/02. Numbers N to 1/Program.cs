using System;

namespace _02._Numbers_N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            for (int i = numb; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}
