using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Lengde array
            Console.WriteLine("Lengde: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index av 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effekten av Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()
            Console.WriteLine("Effekten av Copy()");
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effekten av Sort()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effekten av Reverse()");
            foreach(var n in numbers)
                Console.WriteLine(n);
        }
    }
}
