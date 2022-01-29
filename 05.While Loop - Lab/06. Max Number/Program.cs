using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "Stop")
                {
                    break;
                }
                int number = int.Parse(input);
                if (number > max)
                {
                    max = number;
                    
                }
                
            }

            Console.WriteLine(max);



        }
    }
}
