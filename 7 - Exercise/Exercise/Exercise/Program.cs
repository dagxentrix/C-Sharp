using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oppgave 1
            Console.WriteLine("Skriv et tall mellom 1 og 10");

            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number > 0 && number < 10)
            {
                Console.WriteLine("FLINK");
            }
            else
            {
                Console.WriteLine("idiot");
            }

            //Oppgave 2
            Console.WriteLine("Skriv inn 1 tall");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv inn enda eit");
            var input2 = Convert.ToInt32(Console.ReadLine());

            var max = (input1 > input2) ? input1 : input2;
            Console.WriteLine("Max er: " + max);

            //Oppgave 3
            Console.WriteLine("Skriv inn bredde på bildet");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv inn høyde");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("D E LANSKAPE");
            }
            else if (width < height)
            {
                Console.WriteLine("D e potrett");
            }
            else
            {
                Console.WriteLine("mongobilde XD");
            }

            //Oppgave 4
            Console.WriteLine("Fartsgrense");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kor fort køyrte an");
            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed < speedLimit)
            {
                Console.WriteLine("OKI");
            }
            else
            {
                const int kmPerPrikk = 5;
                var prikker = (speed - speedLimit) / kmPerPrikk;
                if (prikker > 12)
                {
                    Console.WriteLine("FUKK DEG OG FØRARKORTET");
                }
                else
                {
                    Console.WriteLine("Gratulerer med: " + prikker + " prikker, din dust");
                }
            }
        }
    }
}
