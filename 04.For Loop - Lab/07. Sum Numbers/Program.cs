using System;
using System.Threading.Tasks.Dataflow;
using System.Xml.Schema;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
        
            int sum = 0;
            for (int i = 0; i < countOfNumbers; i++)
            {
                
               int number =int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
        
    }
}
