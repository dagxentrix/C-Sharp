using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Math;

namespace Classes
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Person dag = new Person();
            dag.FirstName = "Dag";
            dag.LastName = "Pedersen";
            dag.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
