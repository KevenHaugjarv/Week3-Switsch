using System;

namespace GradingSwisch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib, mis hinde kasutaja sai;
            // kui kasutaja sai "A" konsool kuvab "Suurepärane";
            // kui kasutaja sai "B" konsool kuvab "Väga hea";
            // kui kasutaja sai "C" konsool kuvab "Hea";
            // kui kasutaja sai "D" konsool kuvab "Rahuldav";
            // kui kasutaja sai "E" konsool kuvab "Kasin";
            // kui kasutaja sai "F" konsool kuvab "Puudulik";
            // kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus";

            Console.WriteLine("Sisesta oma tulemus");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane");
                    break;
                case 'B':
                    Console.WriteLine("Väga Hea");
                    break;
                case 'C':
                    Console.WriteLine("Hea");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine($"Vale väärtus");
                    break;

            }

            Console.WriteLine("Head päeva!");

        }
    }
}
