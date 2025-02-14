using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            double minimum = GetMinimum(num1, num2, num3);
            Console.WriteLine($"Минимальное число: {minimum}");

        }
        static double GetMinimum(double a, double b, double c)
        {
            double min = a; // Предполагаем, что a - минимальное
            if (b < min)
            {
                min = b; // Если b меньше, обновляем min
            }
            if (c < min)
            {
                min = c; // Если c меньше, обновляем min
            }
            return min; // Возвращаем минимальное число

           



        }
    }
}
