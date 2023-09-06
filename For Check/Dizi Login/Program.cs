using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int[] saylar = {1,7,2,3,7,4,5,1,6,7,8,9,3,7,1,10 };
              int eded = 0;
              int reqem;
              Console.WriteLine("Reqem yazin:");
              reqem = Convert.ToInt32(Console.ReadLine());

              for(int i=0;i<saylar.Length;i++)
              {
                  if (reqem == saylar[i])
                  {
                      eded++;
                  }

              }
              if(eded==0)
              {
                  Console.WriteLine("Reqem yoxdur.");


              }
              else
              {
                  Console.WriteLine("Yazdiginiz reqem tapildi...");
                  Console.WriteLine("Eded:"+eded);
              }
              Console.ReadLine();*/

            int[] reqemler = { 1,7, 2, 7,3, 7, 4,2,7, 5, 6,3, 7, 8, 3,9,7, 10 };
            int eded = 0;
            int reqem;
            Console.WriteLine("Reqem yazin:");
            reqem = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < reqemler.Length; i++)
            {
                if (reqem == reqemler[i])
                {
                    eded++;
                }
            }
            if(eded==0)
            {
                Console.WriteLine("Reqem tapilmadi.");
            }
            else
            {
                Console.WriteLine(reqem+" reqemi tapildi.");
                Console.WriteLine("Eded:"+eded);

            }
            Console.ReadLine();




        }
    }
}
