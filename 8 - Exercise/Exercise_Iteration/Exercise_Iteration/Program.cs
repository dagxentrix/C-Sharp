using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            //Oppgave 1
            //var count = 0;
            //for(var i = 0; i<=100; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Det er {0} tall som kan deles på 3 mellom 1 og 100", count);


            ////Øvelse 2
            //var sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Skriv tall, eller 'OK' for å avslutte");
            //    var input = Console.ReadLine();

            //    if (input == "OK")
            //        break;
            //    sum += Convert.ToInt32(input);
            //}
            //Console.WriteLine("Summen av tallene er: " + sum);
            ////Oppgave 3
            //Console.WriteLine("Skriv et tall: ");
            //var number = Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;
            //for(var i = 1; i<= number; i++)
            //{
            //    factorial *= i;
            //    Console.WriteLine("{0}! = {1}", number, factorial);
            //}

            ////Oppgave 4
            //var number = new Random().Next(1, 10);

            //Console.WriteLine("Hemmelige tallet er: " + number);

            //for(var i = 0; i<4; i++)
            //{
            //    Console.WriteLine("Gjett");
            //    var guess = Convert.ToUInt32(Console.ReadLine());

            //    if (guess == number)
            //    {
            //        Console.WriteLine("DU VANT");
            //        return;
            //    }
            //}
            //Console.WriteLine("TAPER");
            //Oppgave 5
            Console.WriteLine("Skriv tall med komma i mellom");

            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach(var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Høyeste er: " + max);
        }
    }
}
