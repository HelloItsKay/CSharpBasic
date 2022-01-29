using System;
using System.Threading.Channels;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsDailyGoal = 10000;
            int stepCounter = 0;
            while (stepCounter < stepsDailyGoal)
            {
                string goHome = Console.ReadLine();
                

                if (goHome == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    stepCounter += stepsToHome;
                    break;

                }
                int stepsWalked = int.Parse(goHome);
                stepCounter += stepsWalked;
                //
                //string input = Console.ReadLine();
                //if (input == "NoMoreMoney")
                //{
                //    break;
                //}
                //double sum = double.Parse(input);


            }

            int stepsOverTheGoal = stepCounter - stepsDailyGoal;

            if (stepCounter > stepsDailyGoal)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsOverTheGoal} steps over the goal!");
            }

            int moreStepsToReachTheGoal = stepsDailyGoal - stepCounter;
            if (stepsDailyGoal>stepCounter)
            {
                Console.WriteLine($"{moreStepsToReachTheGoal} more steps to reach goal.");
            }
        }

    }
}

