using System;

namespace _05._Greeting_by_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата име на човек и отпечатва
            //&quot;Hello, &lt;name&gt;!&quot;, където &lt;name&gt; е
            //въведеното име от конзолата.

            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
