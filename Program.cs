using System;

namespace laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполните выбор для вашей компании");

           
            bool free;  
            bool stair; 

            
            Console.WriteLine("Наличие свободных мест: true - да, false - нет:");
            while (!bool.TryParse(Console.ReadLine(), out free))
            {
                Console.WriteLine("Ошибка ввода! Введите true или false:");
            }
            Console.WriteLine("Наличие роста по карьерной лестнице: true - да, false - нет:");
            while (!bool.TryParse(Console.ReadLine(), out stair))
            {
                Console.WriteLine("Ошибка ввода! Введите true или false:");
            }
           

            
            LogicAnd n1 = new LogicAnd();          
            LogicAnd n2 = new LogicAnd(free, stair); 
            LogicAnd n3 = new LogicAnd(n1);        

            // Проверка возможности найма
            bool result = n2.CanHireEmployees(free, stair);
            bool result5 = n2.CanGrowStairs(free,stair);
            bool result6 = n2.CanGetFree(free, stair);
            // Обработка результата
            if (result)
            {
                Console.WriteLine(n1.ToString()); 

            }
            else
            {
                Console.WriteLine("Условия для найма не выполнены!");
            }

            // Дополнительный вывод информации
            Console.WriteLine(n1.ToString());





            double a, b, c; // ▲ Стороны треугольника (лучше инициализировать в момент ввода)

            // ▲ Ввод первого треугольника
            Console.WriteLine("Введите катет a:");

            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Ошибка ввода! Введите положительное число:");
            }
            Console.WriteLine("Катет а:" + a); 

            Console.WriteLine("Введите катет b:");

            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Ошибка ввода! Введите положительное число:");
            }
            Console.WriteLine("Катет b:" + b);

            Console.WriteLine("Введите катет c:");

            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Ошибка ввода! Введите положительное число:");
            }
            Console.WriteLine("Катет с:" + c);

            Triangle n4 = new Triangle(a, b, c); 

            // ▲ Проверка существования треугольника через статический метод
            if (!Triangle.Exist(a, b, c))
            {
                Console.WriteLine("Ошибка: треугольник невозможен!");
            }
            else
            {
                Console.WriteLine("Такой треугольник существует");
            }

            // ▲ Унарный оператор ! для площади
            double result2 = !n4;
            Console.WriteLine($"Площадь треугольника: {result2:F2}");

            // ▲ Неявное приведение к double (возвращает периметр)
            double perimeter = n4;
            Console.WriteLine($"Периметр: {perimeter}");

            // ▲ Явное приведение к bool (существует ли треугольник)
            bool isValid = (bool)n4;
            Console.WriteLine($"Треугольник существует? {isValid}");

            // ▲ Ввод второго треугольника (аналогично первому)
            Console.WriteLine("Введите второй треугольник:");
            Console.WriteLine("Введите катет a:");

            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Ошибка ввода! Введите положительное число:");
            }
            Console.WriteLine("Катет а:" + a);

            Console.WriteLine("Введите катет b:");

            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Ошибка ввода! Введите положительное число:");
            }
            Console.WriteLine("Катет b:" + b);

            Console.WriteLine("Введите катет c:");

            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Ошибка ввода! Введите положительное число:");
            }
            Console.WriteLine("Катет с:" + c);

            Triangle n5 = new Triangle(a, b, c);

            if (!Triangle.Exist(a, b, c))
            {
                Console.WriteLine("Ошибка: треугольник невозможен!");
            }
            else
            {
                Console.WriteLine("Такой треугольник существует");
            }

            double result3 = !n5;
            Console.WriteLine($"Площадь треугольника: {result3:F2}");

            bool isValid2 = (bool)n5;
            Console.WriteLine($"Треугольник существует? {isValid2}");

            // ▲ Сравнение площадей (только если оба треугольника существуют)
            if (isValid && isValid2)
            {
                if (result2 > result3)
                    Console.WriteLine("Первый треугольник БОЛЬШЕ по площади");
                else if (result2 < result3)
                    Console.WriteLine("Второй треугольник БОЛЬШЕ по площади");
                else
                    Console.WriteLine("Треугольники РАВНЫ по площади");
            }
            else
            {
                Console.WriteLine("Сравнение невозможно!");
            }
        }
    }
}
