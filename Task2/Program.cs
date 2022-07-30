using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void GetBoxAreaVolume(double a, out double s, out double v)
        {
            v = Math.Pow(a, 3);
            s = 6 * (a * a);
            Console.WriteLine("Площадь поверхности куба: {0:.00}", s);
            Console.WriteLine("Объем куба: {0:.00}", v);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            Console.Write("A = ");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetBoxAreaVolume(a, out s, out v);
            Console.ReadKey();
        }
    }
}
