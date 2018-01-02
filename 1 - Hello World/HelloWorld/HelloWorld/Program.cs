using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");
            Console.WriteLine("Hva heter du?");

            string input = Console.ReadLine();
            if (input == "Dag")
            {
                Console.WriteLine("Dag er best");
            }
            else
            {
                Console.WriteLine("Hei " + input);
            }            
        }
        
    }
}

