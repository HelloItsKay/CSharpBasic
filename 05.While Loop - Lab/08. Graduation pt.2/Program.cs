using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double averageMark = 0;
            double marksSum = 0;
            int countOfyears = 0;
            int badGradeCounter = 0;
            while (countOfyears < 12)
            {

                double marks = double.Parse(Console.ReadLine());



                if (marks < 4)
                {
                    badGradeCounter++;
                    if (badGradeCounter >= 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {countOfyears} grade");
                        return;
                    }
                }
                marksSum += marks;
                countOfyears++;
                averageMark = marksSum / countOfyears;
            }



            Console.WriteLine($"{name} graduated. Average grade: {averageMark:F2}");
        }
    }
}
