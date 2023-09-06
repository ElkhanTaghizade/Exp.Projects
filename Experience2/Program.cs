using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experience2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //for(int i=0; i<10; i++)
            //{
            //    Console.WriteLine("Enter num:");
            //    int num=Convert.ToInt32(Console.ReadLine());
            //    list.Add(num);

            //}
            //for(int j=0; j<5; j++)
            //{
            //    int array = list[j];
            //    list[j] = list[list.Count-5+j];
            //    list[list.Count-5+j] = array;
            //}


            //foreach(var item in list) 
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(3);

            //HashSet<int> set = new HashSet<int>();
            //set.Add(1);
            //set.Add(2);
            //set.Add(3);
            //set.Add(4);
            //set.Add(1);
            //foreach(var item in set)
            //{
            //    Console.WriteLine(item);
            //}
            //  y=x*x-2x+1
            //List<int> list = new List<int>();
            //int num1=Convert.ToInt32(Console.ReadLine());
            //int num2=Convert.ToInt32(Console.ReadLine());
            //for(int i =num1;i<num2;i++)
            //{
            //    list.Add(Num(num1));
            //}
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //static int Num(int i)
            //{
            //    int y = i * i - 2 * i + 1;
            //    return y;
            //}
            bool check = true;

            while(check)
            {
                Console.WriteLine("To add: 1");
                Console.WriteLine("Exit: 2");
                string choose=Console.ReadLine();
                switch(choose)
                {
                    case "1":
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter price:");
                        int price = Convert.ToInt32(Console.ReadLine());
                        Medicine medicine = new Medicine(name, price);
                        break;
                    
                    case "2":
                        check= false;
                        Console.WriteLine("Exit");
                        break;
                }
            }
        }
    }
    public class Medicine
    {
        private string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Medicine(string name, int price)
        {
            Name= name;
            Price= price;
        }
        
    }
       
}
