using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (var i = 1; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (var i = 10; i >= 1; i--)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            //var name = "Dag Pedersen";

            //for(var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach( var bokstav in name)
            //{
            //    Console.WriteLine(bokstav);
            //}
            //var numbers = new int[] { 1, 2, 3, 4 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //var i = 0;
            //while (i <= 10)
            //{
            //    if(i % 2 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //while løkke
            //while (true)
            //{
            //    Console.Write("Skriv navnet ditt: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }
            //    break;

            //}
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i<passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);

            

        }
    }
}

