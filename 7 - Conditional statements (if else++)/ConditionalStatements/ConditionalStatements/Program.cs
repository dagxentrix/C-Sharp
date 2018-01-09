using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Tidligste");
            }
                
            else if(hour >= 12 && hour < 18)
            {
                Console.WriteLine("Ettermiddag");
            }

            else
            {
                Console.WriteLine("Natta");
            }
            */
            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;
            /*bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);*/
            var season = Seasons.Summer;

            switch (season)
            {
                case Seasons.Autumn:
                case Seasons.Summer:
                    Console.WriteLine("TILBOD SESONG");
                    break;

                default:
                    Console.WriteLine("WHAT IS DIS");
                    break;
            }
        }

    }
}
