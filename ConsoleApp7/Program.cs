using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = Input("r=");
            double p = 1, s = 1;
            Func(r, ref p, ref s);
            Console.WriteLine($"Длина окружности {Math.Round(p, 2)} Площадь окружности {Math.Round(s, 2)}");
            Console.Read();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Func(int r, ref double p, ref double s)
        {
            p = 2 * Math.PI * r;
            s = Math.PI * Math.Pow(r, 2);
        }
    }
}
