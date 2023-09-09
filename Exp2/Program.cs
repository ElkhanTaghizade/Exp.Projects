using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("Elxan", "Tagizade", 19);
            //Console.WriteLine(student.Time());


            //Rectangle rectangle = new Rectangle(2,3);
            //Console.WriteLine("Area:"+rectangle.CalculateArea());
            //Console.WriteLine("Perimetr:"+rectangle.CalculatePerimetr());

            //Circle circle = new Circle(5);
            //Console.WriteLine("Area:" + circle.CalculateArea());
            //Console.WriteLine("Perimetr:" + circle.CalculatePerimetr());

            //Triangle triangle = new Triangle(3, 4, 5);
            //Console.WriteLine("Area:" + triangle.CalculateArea());
            //Console.WriteLine("Perimetr:" + triangle.CalculatePerimetr());

            //Square square = new Square(5);
            //Console.WriteLine("Area:" + square.CalculateArea());
            //Console.WriteLine("Perimetr:" + square.CalculatePerimetr());
            Calculator calculator= new Calculator();
            double[] array = {2,3,4,5};
            string symbl = "+";
            Console.WriteLine(calculator.num(array, symbl));
        }
    }
    interface ISum
    {
        double num(double[]numbers, string symbl);
    }
    interface IDiffernce
    {
        double num(double[] numbers, string symbl);
    }
    interface IMultiply
    {
        double num(double[] numbers, string symbl);
    }
    interface IDivide
    {
        double num(double[] numbers, string symbl);
    }
    public class Calculator:ISum,IDiffernce,IMultiply,IDivide
    {
        public double num(double[] numbers, string symbl) 
        {
            if(symbl=="+")
            {
                double sum = 0;
                for(int i=0; i<numbers.Length; i++)
                {
                    sum = numbers[i] + numbers[i+1];
                }
                return sum;
            }

            if (symbl == "-")
            {
                double dif = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    dif = numbers[i] + numbers[i + 1];
                }
                if(dif < 0)
                {
                    dif = -1 * dif;
                }
                return dif;
            }
            if (symbl == "*")
            {
                double mul = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    mul = numbers[i] * numbers[i + 1];
                }
                return mul;
            }
            if (symbl == "/")
            {
                double div1;
                double div = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    div1 = numbers[0];
                    div = numbers[i] / div1;
                }
                return div;
            }
            else
            {
                return 0;
            }
        }
    }


    interface IFigure
    {
        double CalculateArea();
        double CalculatePerimetr();
    }

    public class Rectangle : IFigure
    {
         double a { get; set; }
         double b { get; set; }
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double CalculateArea()
        {
            double area = a * b;
              return area;
        }

        public double CalculatePerimetr()
        {
            double perimetr = 2 * (a + b);
             return perimetr;
        }
    }
    public class Circle:IFigure
    {
        double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            double area = radius * radius * Math.PI;
            return area;
        }
        public double CalculatePerimetr()
        {
            double perimetr = 2 * Math.PI * radius;
            return perimetr;
        }
    }
    public class Triangle:IFigure
    {
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double CalculateArea()
        {
            double S = (a + b + c) / 2;
            double area = S * (S - a) * (S - b) * (S - c);
            return area;
        }
        public double CalculatePerimetr()
        {
            double perimetr = a + b + c;
            return perimetr;
        }
    }
    public class Square : IFigure
    { 
        double a { get; set; }
        public Square(double a)
        {
            this.a = a;
        }
        public double CalculateArea()
        {
            double area = a * a;
            return area;
        }
        public double CalculatePerimetr()
        {
            double perimetr = 4 * a;
            return perimetr;
        }
    }

    public class Student
    {
        public string Name { get; }
        public string SurName { get; }
        public byte Age { get; }
        private static int time = 0;
        public Student(string name, string surname, byte age)
        {
            Name = name;
            SurName = surname;
            Age = age;
            time++;

        }
        public int Time()
        {
            return time;
        }
    }
}
