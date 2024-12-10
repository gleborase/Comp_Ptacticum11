using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        //Task1
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static double Func(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            int x1 = Input("x1=");
            int x2 = Input("x2=");
            int x3 = Input("x3=");
            int x4 = Input("x4=");
            int x5 = Input("x5=");
            int y1 = Input("y1=");
            int y2 = Input("y2=");
            int y3 = Input("y3=");
            int y4 = Input("y4=");
            int y5 = Input("y5=");
            double s = Square(Func(x1, y1, x2, y2), Func(x2, y2, x3, y3), Func(x3, y3, x1, y1))
                     + Square(Func(x1, y1, x5, y5), Func(x5, y5, x4, y4), Func(x4, y4, x1, y1))
                     + Square(Func(x1, y1, x4, y4), Func(x4, y4, x3, y3), Func(x3, y3, x1, y1));
            Console.WriteLine($"Square={s}");
            Console.Read();
        }
    }
}
