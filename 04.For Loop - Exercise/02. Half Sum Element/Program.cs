using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                sum += numb;


                if (numb > maxNum)
                {
                    maxNum = numb;
                }

            }
            int sumWithoutTheMaxNum = sum - maxNum;
            if (sumWithoutTheMaxNum==maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutTheMaxNum}");
            }
            else
            {
                int diff = Math.Abs(maxNum - sumWithoutTheMaxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }

        }
    }
}
