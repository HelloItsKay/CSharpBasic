using System;
using System.Threading.Channels;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGradesLimit = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();
            string lastTask = "";

            int poorGradeCounter = 0;
            int gradeCounter = 0;
            int sum = 0;


            while (task != "Enough")
            {
                lastTask = task;

                int grade = int.Parse(Console.ReadLine());
                sum += grade;

                gradeCounter++;
                if (grade <= 4)
                {
                    poorGradeCounter++;
                    if (poorGradeCounter == poorGradesLimit)
                    {
                        Console.WriteLine($"You need a break, {poorGradeCounter} poor grades.");
                        break;
                    }



                }

                task = Console.ReadLine();
            }

            if (poorGradeCounter != poorGradesLimit)
            {

                double averageScore = 1.0 * sum / gradeCounter;

                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {gradeCounter}");
                Console.WriteLine($"Last problem: {lastTask}");

            }



        }
    }
}
