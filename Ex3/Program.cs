using System;

namespace Ex3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 3; i >= 0; i--)
            {
                sum += x / (int)Math.Pow(10.0, i);
                x = x % (int)Math.Pow(10.0, i);
            }
            Console.WriteLine(sum);
        }
    }
}
