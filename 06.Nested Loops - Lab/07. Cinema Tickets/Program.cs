using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheMuvie = Console.ReadLine();
            string name = "";
            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;
            int ticketsForTheMuvie = 0;
            int totalTickets = 0;

            double studentPercentage = 0;
            double standardPercentage = 0;
            double kidPercentage = 0;

            int kids = 0;
            int students = 0;
            int standard = 0;

            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;

            while (nameOfTheMuvie != "Finish")
            {
                if (nameOfTheMuvie != "Finish")
                {

                    name = nameOfTheMuvie;

                }

                int freeSeats = int.Parse(Console.ReadLine());
                string typeTicket = Console.ReadLine();
                for (int i = 0; i < freeSeats; i++)
                {

                    if (typeTicket == "student")
                    {
                        totalTickets++;
                        studentCounter++;
                        students++;
                    }
                    else if (typeTicket == "standard")
                    {
                        totalTickets++;
                        standardCounter++;
                        standard++;
                    }
                    else if (typeTicket == "kid")
                    {
                        totalTickets++;
                        kidCounter++;
                        kids++;
                    }
                    else if (typeTicket == "End")
                    {
                        break;
                    }

                    ticketsForTheMuvie = studentCounter + standardCounter + kidCounter;
                    typeTicket = Console.ReadLine();
                }


                totalStudent += students;
                totalStandard += standard;
                totalKid += kids;

                studentPercentage = (double)totalStudent / freeSeats * 100;
                standardPercentage = (double)totalStandard / freeSeats * 100;
                kidPercentage = (double)totalKid / freeSeats * 100;
                double chart = ((double)ticketsForTheMuvie) / freeSeats * 100;
                Console.WriteLine($"{name} {chart:F2} % full.");
                studentCounter = 0;
                standardCounter = 0;
                kidCounter = 0;


                nameOfTheMuvie = Console.ReadLine();


            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercentage} % student tickets.");
            Console.WriteLine($"{standardPercentage} standard tickets.");
            Console.WriteLine($"{kidPercentage} kids tickets.");
            //66.67 % student tickets.
            //25.00 % standard tickets.
            //8.33 % kids tickets.


        }
    }
}
