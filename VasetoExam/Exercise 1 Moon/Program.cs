using System;

namespace Exercise_1_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            double weight = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string activity = Console.ReadLine();
            double bmi = 0;
            high = high * 100;

            switch (gender)
            {
                case "m":
                    bmi = 66 + (13.7 * weight) + (5 * high) - (6.8 * age);
                    break;

                case "f":
                    bmi = 655 + (9.6 * weight) + (1.8 * high) - (4.7 * age);
                    break;

            }

            switch (activity)
            {
                case "sedentary":
                    bmi *= 1.2;
                    break;

                case "lightly active":
                    bmi *= 1.375;
                    break;

                case "moderately active":
                    bmi *= 1.55;
                    break;

                case "very active":
                    bmi *= 1.725;
                    break;

            }

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(bmi)} calories per day.");
        }
    }
}
