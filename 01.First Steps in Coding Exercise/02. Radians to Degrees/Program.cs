using System;
using System.Net.NetworkInformation;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)

        {
            //Напишете програма, която чете ъгъл в радиани (rad) и го преобразува в градуси (deg). Използвайте формулата: градус = радиан * 180 / π.Числото π в C# програми е достъпно чрез Math.PI. Закръглете резултата до най-близкото цяло число използвайки Math.Round().
            //1.	Прочетете входните данни от конзолата (радианите):
            double rad = double.Parse(Console.ReadLine());
            //2.	Създайте нова променлива, в която ще направите конвертирането от радиани към градуси, като знаете формулата за изчисление:
            double deg = rad * 180 / Math.PI;

            //3.	Принтирайте получените градуси, като закръглите резултата цяло число (използвайте метода Math.Round()):
            


            Console.WriteLine($"{Math.Round(deg)}");
        }
    }
}
