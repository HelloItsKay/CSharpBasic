using System;

namespace _03._Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbOne = int.Parse(Console.ReadLine());
            if (numbOne % 2==0)
            {
                Console.WriteLine("even");//4%2=2 0==0 => true=>even
            }
            else
            {
                Console.WriteLine("odd");//5%2=1==0 =>false => odd
            }

            

        }
    }
}
