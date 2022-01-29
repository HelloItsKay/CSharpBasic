using System;
using System.Data.SqlTypes;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            
           

           

            double persentFromBudget = 0;
            string typeOfHoliday = "";
            string destination = "";
            

            switch (season)
            {   
               

                case "summer":
                    typeOfHoliday = "Camp";
                    
                    
                    if (budget<=100)
                    {
                       destination = "Somewhere in Bulgaria";
                        
                       
                        persentFromBudget = 0.30;

                    }

                    else if (budget<=1000)
                    {
                         destination = "Somewhere in Balkans";
                        persentFromBudget = 0.40;
                    }
                    else
                    {
                        typeOfHoliday = "Hotel";
                        destination = "Somewhere in Europe";
                        persentFromBudget = 0.90;
                    }
                    break;
                    

                case "winter":

                    typeOfHoliday = "Hotel";

                    if(budget <= 100)
                    {

                         destination = "Somewhere in Bulgaria";
                        persentFromBudget = 0.70;

                    }
                    else if (budget<=1000)
                    {
                         destination = "Somewhere in Balkans";
                        persentFromBudget = 0.80;
                    }
                    else
                    {
                        
                        destination = "Somewhere in Europe";
                        persentFromBudget = 0.90;
                    }
                    break;





                  

            }
                    
                    double spendMoney = budget * persentFromBudget;
            
                
                Console.WriteLine($"{destination}");
                Console.WriteLine($"{typeOfHoliday} - {spendMoney:F2}");
        }
    }
}
