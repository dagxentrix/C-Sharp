using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var tall = "1234";
                byte b = Convert.ToByte(tall);
                Console.WriteLine(b);

                string str = "true";
                bool bol = Convert.ToBoolean(str);
                Console.WriteLine(bol);

            }
            catch (Exception)
            {

                Console.WriteLine("Tallet kan ikke bli konvertert til byte");
            }
            byte number = 2;
            int count = int.MaxValue;
            string firstName = "Dag";
            bool isWorking = false;
            Console.WriteLine(number + " " + count + " " + firstName);
            if (isWorking == true)
            {
                Console.WriteLine("Funksjer");
            }
            else
            {
                Console.WriteLine("Funkjer ikkje");
            }
        }
    }
}
