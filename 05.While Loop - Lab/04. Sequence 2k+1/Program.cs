using System;
using System.Threading.Channels;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                sum = sum * 2 + 1;
                 
                if (sum > startNumber)
                {
                    break;
                }
                Console.WriteLine(sum);
            }


           
        }
    }
}
