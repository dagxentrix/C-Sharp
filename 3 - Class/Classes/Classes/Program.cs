using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Math;

namespace Classes
{
    public class Human
    {
        public int Age;
    }
   
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


            //reference types and value types
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("A1: {0}, A2: {1}", array1[0], array2[0]));

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var human = new Human() { Age = 20 };
            MakeOld(human);
            Console.WriteLine(human.Age);
            
        }
        public static void Increment (int number)
        {
            number += 10;
        }
        public static void MakeOld(Human human)
        {
            human.Age += 10;
        }
    }
}
