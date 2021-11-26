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
            string str1 = "Ветер дует с севера на запад. ";
            string str2 = "Дождь идёт с утра не переставая.";
            string str3 = "Единая система предупреждения и ликвидации ЧС";
            string str4 = string.Concat(str1,str2);

            Console.Write(str4);

            //int spase_index = str4.IndexOf(' ');

            string[] strs = str4.Split(' ');
            for (int i = 0; i < strs.Length; i++)
                Console.WriteLine($" {i + 1}-е слово: {strs[i]}");


        }
    }
}
