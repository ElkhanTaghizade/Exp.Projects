using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERMINAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balans= 88.5;
            Console.WriteLine("Xos geldiniz!");
            Console.WriteLine("Balansinizi oyrenmek ucun:1");
            Console.WriteLine("Pul cekmek ucun:2");
            Console.WriteLine("Balansi artirmaq ucun:3");
            Console.WriteLine("Cixis etmek ucun:0");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Balansiniz:" + balans);

            }

            else if (secim == 2)
            {
                Console.WriteLine("Cekmek istediyiniz meblegi yazin:");
                int mebleg = Convert.ToInt32(Console.ReadLine());
                if (mebleg <= 88.5)
                {
                    Console.WriteLine("Balans:" + (balans - mebleg));
                }
                else
                {
                    Console.WriteLine("Balansiniz yeterli deyil");
                }
            }
            else if(secim==3)
            {
                Console.WriteLine("Elave etmek istediyiniz meblegi yazin:");
                int elave = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Balans:"+(balans+elave));


            }
            else if(secim==0)
            {
                Console.WriteLine("Tesekkurler...");

            }
            else
            {
                Console.WriteLine("Xahis olunur yalniz verilen reqemlerden istifade edin.");
            }
            Console.ReadLine();
                      
        }
    }
}
