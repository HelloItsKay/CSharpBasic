using System;
     


namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double   num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();


            double sum = 0;


            if ((operation == "/" || operation == "%") && num1 == 0)
            {
                Console.WriteLine($"Cannot divide {num2} by zero");
                return;
            }

            if ((operation == "/" || operation == "%") && num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
                return;
            }



            switch (operation)
            {

                case "+":
                    sum = num1 + num2;

                    break;

                case "-":
                    sum = num1 - num2;
                    break;

                case "*":
                    sum = num1 * num2;
                    break;

                case "/":
                    sum = num1 / num2;
                    break;

                case "%":
                    sum = num1 % num2;
                    break;

            }


            string oddOrNot = "";


            if (sum % 2 == 0)

            {
                oddOrNot = "even";
            }
            else
            {
                oddOrNot = "odd";
            }


            if (operation == "/")
            {
                Console.WriteLine($"{num1} {operation} {num2} = {sum:F2}");
            }
            else if (operation == "%")
            {
                Console.WriteLine($"{num1} {operation} {num2} = {sum}");
            }
            else
            {
                Console.WriteLine($"{num1} {operation} {num2} = {sum} - {oddOrNot}");
            }


            

        }
    }
}