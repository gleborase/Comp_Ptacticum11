using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        //Task2
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int d = Input("d=");
            Console.WriteLine($"До обмена:{a}\t{b}\t{c}\t{d}");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.WriteLine($"После обмена:{a}\t{b}\t{c}\t{d}");
            Console.Read();
        }
        static void Swap(ref int x, ref int y)
        {
            int p = x;
            x = y;
            y = p;
        }
    }
}
