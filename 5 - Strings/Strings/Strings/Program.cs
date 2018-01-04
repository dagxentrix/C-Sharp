using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Dag";
            var lastName = "Pedersen";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("Jeg heter {0} {1}", firstName, lastName);

            Console.WriteLine("fullName =" + fullName);
            Console.WriteLine("myFullName =" + myFullName);

            var names = new string[3] { "Dag", "Dagny", "Dagrun" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var myText = "Hey Dagny\n se på denne stien\n c:\\mappe1\\mappe2\\mappe3";
            var text = @"Hey Dag
Se på denne stien
c:\mappe1\mappe2\mappe3";
            Console.WriteLine(myText);
            Console.WriteLine(text);
        }
    }
}
