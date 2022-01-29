using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            //За рожденният ден на дъщеря си Людмила е решила да организира парти, на което да покани всичките ѝ съученици. За целта е решила да наеме развлекателна зала за деца, чийто наем ще получите като вход от конзолата. 

            double rent = double.Parse(Console.ReadLine());
            //•	Торта  – цената ѝ е 20% от наема на залата
            double cake = rent * 0.2;
            //•	Напитки – цената им е 45% по-малко от тази на тортата
            double drinks = cake - (cake * 0.45);
            //•	Аниматор – цената му е 1/3 от цената за наема на залата
            double animator = rent / 3;
                //необходима сума 
                double totalAmount = rent + cake + drinks + animator;
            Console.WriteLine($"{totalAmount}");



        }
    }
}
