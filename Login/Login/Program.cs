using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int haqq = 3;
            while (true)
            {
                Console.WriteLine("Istifadeci adinizi daxil edin:");
                String ad = Console.ReadLine();
                Console.WriteLine("Sifrenizi daxil edin:");
                string sifre = Console.ReadLine();
                if(ad=="elxan" ||ad=="Elxan"|| && sifre== "e1234567")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Istifadeci adi ve ya sifre yalnisdir.");

                    if (haqq>0)
                    {
                        haqq -= 1;
                    }
                    Console.WriteLine("Icaze verilen cehd sayi:" + haqq);

                    if (haqq==0)
                    {
                        Console.WriteLine("Haqqiniz bitmisdir, cixis edilir..");
                        break;
                    }
                }
                





            } Console.ReadLine();


        }
    }
}
