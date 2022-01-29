using System;



class Program
{

    static void Main(string[] args)
    {
       
        int location = int.Parse(Console.ReadLine());

        for (int i = 0; i < location; i++)
        {
            double avrExtraction = double.Parse(Console.ReadLine());
            int days =int.Parse(Console.ReadLine());
            double sumExtraction = 0;
                
            for (int j = 0; j < days; j++)
            {
                double extraction = double.Parse(Console.ReadLine());
                sumExtraction += extraction;
            }
            double average = sumExtraction / days;
            if (average >= avrExtraction)
            {
                Console.WriteLine($"Good job! Average gold per day: {average:F2}.");
            }
            else
            {
                Console.WriteLine($"You need {avrExtraction-average:F2} gold.");
            }
        }
    }

}