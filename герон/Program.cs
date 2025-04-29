using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace герон
{
    class geron
    {
        private double a;
        private double b;
        private double c;
        public geron(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double VicislPlosh()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool proverka()
        {
            return (a + b > c && a + c > b && b + c > a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первой стороны треугольника: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второй стороны треугольника: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину третьей стороны треугольника: ");
            double c = Convert.ToDouble(Console.ReadLine());
            geron treugol = new geron(a, b, c);
            if (treugol.proverka())
            {
                double x = treugol.VicislPlosh();
                Console.WriteLine("площадь треугольника: " + x);
            }
            else
            {
                Console.WriteLine("такого треугольника не существует");
            }
            Console.ReadKey();
        }
    }
}
