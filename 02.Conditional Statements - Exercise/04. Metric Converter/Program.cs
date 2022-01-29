using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputValue = Console.ReadLine();
            string outputValue =Console.ReadLine();

            double outputNumber = 0;

            if (inputValue == "mm" && outputValue == "m")
            {
                outputNumber = number / 1000;

            }
            else if (inputValue == "m" && outputValue == "mm")
            {
                outputNumber = number * 1000;
            }
            else if (inputValue == "cm" && outputValue == "m")
            {
                outputNumber = number / 100;
            }
            else if (inputValue == "m" && outputValue == "cm")
            {
                outputNumber = number * 100;
            }
            else if (inputValue=="mm"&& outputValue=="cm")

            {
                outputNumber = number / 10;

            }
            else if (inputValue=="cm"&& outputValue=="mm")
            {
                outputNumber = number * 10;
            }


            Console.WriteLine($"{outputNumber:f3}");
        }
    }
}
