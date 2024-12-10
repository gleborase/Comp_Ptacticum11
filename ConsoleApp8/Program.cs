using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static double Perimeter(double x, double y, double z)
        {
            return (x + y + z);
        }
        public static double Square(double x, double y, double z)
        {
            double s = (x + y + z) / 2;
            return Math.Sqrt(s * (s - x) * (s - y) * (s - z));
        }
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            int c = Input("c= ");

            int a1 = Input("a1= ");
            int b1 = Input("b1= ");
            int c1 = Input("c1= ");
            double P1 = Perimeter(a, b, c);
            double P2 = Perimeter(a1, b1, c1);
            double S1 = Square(a, b, c1);
            double S2 = Square(a1, b1, c1);

            Console.WriteLine($"сумма периметров:{P1 + P2}");
            Console.WriteLine($"сумма площадей:{S1 + S2}");
            Console.Read();
        }
    }
}
