using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            Func(ref b, ref c);
            Func(ref a, ref b);
            Func(ref b, ref c);
            Conclusion("По возрастанию",a,b,c);
            Console.Read();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Func(ref int a,ref int b)
        {
           if (a > b)
            {
                int p = a;
                a = b;
                b = p;
            }
        }
        public static void Conclusion(string message, int a, int b, int c)
        {
                Console.WriteLine($"{message} {a},{b},{c}");
        }
    }
}
