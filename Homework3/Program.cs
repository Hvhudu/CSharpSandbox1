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
            int[] arr = new int[10];
            Random rnd = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0,10);
                Console.Write($"{arr[i]} ");
                Array.Sort(arr);
                if (arr[i] == 0) 
                {
                    
                }
            }
            
        }
    }
}
    
