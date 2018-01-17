using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oppgave 1
            //var names = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Skriv inn navn og trykk 'Enter'. Avslutt ved å ikke skrive noe og trykk 'Enter'.");
            //    var input = Console.ReadLine();
            //    if (input != "")
            //    {
            //        names.Add(input);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //if (names.Count < 1)
            //{
            //    Console.WriteLine("Ingen liker innlegget");
            //}
            //else if (names.Count == 1)
            //{
            //    Console.WriteLine(names[0] + " liker innlegget ditt");
            //}
            //else if (names.Count == 2)
            //{
            //    Console.WriteLine(names[0] + " og " + names[1] + " liker innlegget ditt");
            //}
            //else
            //{
            //    Console.WriteLine(names[0] + " , " + names[1] + " og " + (names.Count - 2) + " andre liker innlegget");
            //}
            //Oppgave 2
            //Console.WriteLine("Å heitå du då?");
            //var name = Console.ReadLine();
            //var array = new char[name.Length];

            //for (var i = name.Length; i > 0; i--)
            //{
            //    array[name.Length - i] = name[i - 1];
            //}
            //var reversed = new string(array);
            //Console.WriteLine(reversed);
            //Oppgave 3
            //var numbers = new List<int>();

            //while (numbers.Count < 5)
            //{
            //    Console.WriteLine("Skriv et tall: ");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    if (numbers.Contains(number))
            //    {
            //        Console.WriteLine("Du har allerede tastet " + number);
            //        continue;
            //    }
            //    numbers.Add(number);
            //}
            //numbers.Sort();
            //foreach(var number in numbers)
            //    Console.WriteLine(number);
            //Oppgave 4
            //var numbers = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Skriv tall. Avslutt med å skrive 'Slutt'");
            //    var input = Console.ReadLine();

            //    if (input == "Slutt")
            //    {
            //        break;
            //    }
            //    numbers.Add(Convert.ToInt32(input));
            //}
            //var uniques = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //}
            //Console.WriteLine("Unike tall: ");
            //foreach (var number in uniques)
            //    Console.WriteLine(number);
            //Oppgave 5
            string[] elements;

            while (true)
            {
                Console.WriteLine("Skriv minst 5 tall med ',' i mellom tallene. Eks: 1, 2, 3, 4, 5");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Ugyldig");
            }
            var numbers = new List<int>();
            foreach(var number in elements)
                numbers.Add(Convert.ToInt32(number));
            
            var smallest = new List<int>();
            while(smallest.Count < 3)
            {
                var min = numbers[0];
                foreach(var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallest.Add(min);
                numbers.Remove(min);
            }
            Console.WriteLine("De 3 minste er: ");
            foreach(var number in smallest)
                Console.WriteLine(number);             
        }
    }
}
