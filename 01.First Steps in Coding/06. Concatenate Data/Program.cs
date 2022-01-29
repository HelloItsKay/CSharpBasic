using System;

namespace _06._Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която прочита от конзолата име, фамилия, възраст и град
            //и печата съобщение от следния вид:  You are firstName lastName  age -years old person
            //from town 

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
