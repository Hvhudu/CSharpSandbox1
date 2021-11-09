using System;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите длинну окружности: ");
            double leight = Convert.ToDouble(Console.ReadLine());
            const double PI = 3.14;
            double result = leight / (2 * PI);
            Console.WriteLine($"Радиус равен: {result}");

        }
    }


}
