using System;

namespace _01._2_Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToBeFound = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int count = 0;

            while (currentBook!=bookToBeFound)
            {
                
                if (currentBook=="No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;
                }
                count++;
                currentBook = Console.ReadLine();
            }

            if (currentBook!="No More Books")
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            
            
        }
    }
}
