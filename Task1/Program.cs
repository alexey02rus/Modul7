using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double GetAreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника.");
            Console.Write("a1 = ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1 = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1 = ");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго треугольника.");
            Console.Write("a2 = ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2 = ");
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetAreaTriangle(a1, b1, c1);
            double s2 = GetAreaTriangle(a2, b2, c2);
            if (s1 > s2)
            {
                Console.WriteLine($"Площадь первого треугольника больше ({s1:.00} > {s2:.00}).");
            }
            else if (s1 < s2)
            {
                Console.WriteLine($"Площадь второго треугольника больше ({s1:.00} < {s2:.00}).");
            }
            else
            {
                Console.WriteLine($"Площади треугольников равны ({s1:.00}).");
            }
            Console.ReadKey();
        }
    }
}
