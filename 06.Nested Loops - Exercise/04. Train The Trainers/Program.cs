using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfJudges = int.Parse(Console.ReadLine());
            string nameOfThePresentation = Console.ReadLine();

            double sumGrade = 0;
            double sumFinalGrade = 0;
            double averageFinalGrade = 0;
            int count = 0;
            while (nameOfThePresentation != "Finish")
            {
                count++;
                for (int i = 0; i < countOfJudges; i++)
                {
                    double gradeOfPresentation = double.Parse(Console.ReadLine());
                    sumGrade += gradeOfPresentation;
                    sumFinalGrade += sumGrade;

                }

                double averageGrade = sumGrade / countOfJudges;
                averageFinalGrade += averageGrade;
                

                Console.WriteLine($"{nameOfThePresentation} - {averageGrade:F2}.");

                sumGrade = 0;
                nameOfThePresentation = Console.ReadLine();
            }



            Console.WriteLine($"Student's final assessment is {averageFinalGrade/count:F2}.");

        }
    }
}
