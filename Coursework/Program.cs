using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rhombus[] rhombus = new Rhombus[10];
            for (int i = 0; i < rhombus.Length; i++)
            {
                rhombus[i] = new Rhombus();
                Console.WriteLine("rhombus[" + i + "]");
                rhombus[i].Input();
                rhombus[i].Output();
                rhombus[i].Area();
                Console.WriteLine("Area=" + rhombus[i].Area());
                Console.WriteLine(" ");
            }
            Rhombus biggest = new Rhombus();
            for (int i = 0; i < rhombus.Length; i++)
            {
                if (biggest.Area() < rhombus[i].Area())
                {
                    biggest = rhombus[i];
                }
            }
            Console.WriteLine("Biggsest area=" + biggest.Area());
        }
    }
    class Rhombus
    {
        private double a, alpha;
        public Rhombus()
        {
            a = 0;
            alpha = 0;
        }
        public Rhombus(double a, double alpha)
        {
            this.a = a;
            this.alpha = alpha;
        }
        public void Input()
        {
            Console.Write("Side=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Angle=");
            alpha = Convert.ToDouble(Console.ReadLine());
        }
        public void Output()
        {
            Console.Write("Side=" + a);
            Console.Write(",");
            Console.WriteLine("Angle=" + alpha);
        }
        public double Area()
        { return a * a * Math.Sin(alpha); }
    }
}

        
    

