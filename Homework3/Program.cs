using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Введите число : ");
             int num = Convert.ToInt32(Console.ReadLine());
             Console.Write("{0} = 1", num);
             for (int i = 0; num % 2 == 0; num /= 2)
             {
                    Console.Write(" * {0}", 2);
             }
             for (int i = 3; i <= num;)
             {
                if (num % i == 0)
                {
                    Console.WriteLine(" * {0}", i);
                    num /= i;
                }
                else
                {
                    i += 2;
                }
             }         
        }
    }
}
    
