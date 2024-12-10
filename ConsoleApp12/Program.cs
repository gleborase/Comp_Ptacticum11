using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        public static double Input(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            double x1 = Input("x1= ");
            double x2 = Input("x2= ");
            double x3 = Input("x3= ");
            double y1 = Input("y1= ");
            double y2 = Input("y2= ");
            double y3 = Input("y3= ");

            double a = Length(x1, y1, x2, y2);
            double b = Length(x2, y2, x3, y3);
            double c = Length(x3, y3, x1, y1);

            Console.WriteLine($"Тип треугольника: {Type(a, b, c)}");
            Console.Read();
        }
        public static double Length(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static string Type(double a, double b, double c)
        {
            if (a == b && b == c)

            { return "равносторонний"; }

            else if (a == b || b == c || a == c)

            { return "равнобедренный"; }

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                     Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                     Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
            {
                return "прямоугольный";
            }
            else

            {
                return "обычный";
            }
        }
        

        
    }
}
