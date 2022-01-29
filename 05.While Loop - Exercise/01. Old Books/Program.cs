using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToBeFound = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int count = 0;

            while (currentBook != "No More Books")
            {

                if (bookToBeFound == currentBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                count++;
                currentBook = Console.ReadLine();
            }

            if (bookToBeFound != currentBook)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }

        }
    }
}
