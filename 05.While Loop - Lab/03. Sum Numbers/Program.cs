using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (sum>= target)
                {
                    break; 
                }

            }

            Console.WriteLine(sum);
           
         
        }
    }
}
