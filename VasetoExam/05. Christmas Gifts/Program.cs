using System;

namespace _05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageOfOneFamilyMember = Console.ReadLine();
            int kids = 0;
            int adult = 0;

            while (ageOfOneFamilyMember != "Christmas")

            {
                int ageOfFamilyMemvber = int.Parse(ageOfOneFamilyMember);

                if (ageOfFamilyMemvber <= 16)
                {
                    kids++;
                }

                if (ageOfFamilyMemvber>16)
                {
                    adult++;
                }

                ageOfOneFamilyMember = Console.ReadLine();
            }

            double priseOfToys = kids * 5;
            double priseOfPullovers = adult * 15;

            Console.WriteLine($"Number of adults: {adult}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {priseOfToys}");
            Console.WriteLine($"Money for sweaters: {priseOfPullovers}");

        }
    }
}
