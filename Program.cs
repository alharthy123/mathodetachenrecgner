using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathode_aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {

            double sub;
            double sub2;
            double su;
            string antwort;
            
            Console.WriteLine("geben sie zwei zahlen ein:");
            Console.Write("a=");
            sub = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            sub2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("rechnung (+,-,+,/)");
            antwort = Console.ReadLine();
            if (antwort == "+")
            {
             Console.WriteLine("addition");
            su = addition(sub, sub2);
            Console.WriteLine("ergabnes des addition : " + su);
            }
            else if (antwort == "-")
            {
               Console.WriteLine("subtraktion");
            su = subtraktion(sub, sub2);
            Console.WriteLine("ergabnes des subtraktion : " + su);
            }
            else if (antwort == "*")
            {
             Console.WriteLine("multtiplikation");
            su = multiblikation(sub, sub2);
            Console.WriteLine("ergabnes des multiblikation : " + su);
            }
            else if (antwort == "/")
            {

            Console.WriteLine("divison");
            su = division(sub, sub2);
            Console.WriteLine("ergabnes des division : " + su);
            }
            else
            {
                Console.WriteLine("falsch eingewält");
            }
                     
            Console.WriteLine();
            Console.ReadLine();
        }
        static double subtraktion(double n, double m)
        {
            return n - m;
        }
        static double multiblikation(double a ,double b)
        {
            return a * b;   
        }
        static double addition(double c , double d)
        {
            return c + d;
        }
        static double division(double v, double n)
        {
            return v % n;
        }

        
        

    }
}
