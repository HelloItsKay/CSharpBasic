using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //За рождения си ден Любомир получил аквариум с формата на паралелепипед.Първоначално прочитаме от конзолата на отделни редове размерите му – дължина, широчина и височина в сантиметри.Трябва да се пресметне колко литра вода ще събира аквариума, ако се знае, че определен процент от вместимостта му е заета от пясък, растения, нагревател и помпа.
            //Един литър вода се равнява на един кубичен дециметър / 1л = 1 дм3 /.
            //Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.


            //1.Дължина в см – цяло число в интервала[10 … 500]
            int lengthInCm = int.Parse(Console.ReadLine());
            //2.	Широчина в см – цяло число в интервала [10 … 300]
            int widthInCm = int.Parse(Console.ReadLine());
            //3.	Височина в см – цяло число в интервала [10… 200]
            int heightInCm = int.Parse(Console.ReadLine());
            //4.	Процент който е зает с пясък  – реално число в интервала [0.000 … 100.000]
            double percentConsole = double.Parse(Console.ReadLine());
            double percent = percentConsole * 0.01;


            //counts •	литрите вода, които ще  събира аквариума.
            double aquariumVolume = lengthInCm * widthInCm * heightInCm;
            double aquariumVolumeInLitters = aquariumVolume * 0.001;
            double aquariumVolumeFull = aquariumVolumeInLitters - (aquariumVolumeInLitters * percent);

            Console.WriteLine($"{aquariumVolumeFull}");



        }
    }
}
