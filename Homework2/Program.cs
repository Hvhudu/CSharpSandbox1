using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double root1,root2;
            double D;
           
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToDouble(Console.ReadLine());

            D = (b * b) - 4 * (a * c);

            root1 = ((b * (-1)) + Math.Sqrt(D)) / 2 * a;
            root2 = ((b * (-1)) - Math.Sqrt(D)) / 2 * a;

            Console.WriteLine($"Корни квадратного уравнения {a}x^2 + {b}x - {c} = 0");
            Console.WriteLine($"x1 = {root1}");
            Console.WriteLine($"x2 = {root2}");
        }
    }
}
