using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    public class Triangle
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            // ▲ Проверка на положительные стороны
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Ошибка!");
                Environment.Exit(1); 
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // ▲ Статический метод проверки существования треугольника
        public static bool Exist(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // ▲ Перегрузка унарного оператора ! (возвращает площадь)
        public static double operator !(Triangle t)
        {
            double p = (t.a + t.b + t.c) / 2; 
            return Math.Sqrt(p * (p - t.a) * (p - t.b) * (p - t.c)); 
        }

        // ▲ Неявное приведение к double (возвращает периметр)
        public static implicit operator double(Triangle t)
        {
            return t.a + t.b + t.c;
        }

        // ▲ Явное приведение к bool (проверка существования)
        public static explicit operator bool(Triangle t)
        {
            return t.a + t.b > t.c &&
                   t.a + t.c > t.b &&
                   t.b + t.c > t.a;
        }
    }
}
