using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20
{
    //В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:
    //-метод получает входным параметром переменную типа double;
    //-метод возвращает значение типа double, которое является результатом вычисления.
    //Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
    //- длину окружности по формуле D = 2 * π * R;
    //- площадь круга по формуле S = π* R²;
    //- объем шара.Формула V = 4 / 3 * π * R³.
    //Методы должны быть объявлены как статические.
    class Program
    {
        static void Main(string[] args)
        {           
            Sphere.Methods sphereMethods = null;            
            Console.WriteLine("Введите код операции:\n1 - вычисление длины окружности\n2 - вычисление площади круга\n3 - вычисление объема шара");
            ConsoleKey consolekey = Console.ReadKey().Key;
            while (sphereMethods == null)
            {
                switch (consolekey)
                {
                    case ConsoleKey.D1:
                        sphereMethods = Sphere.Length;
                        break;
                    case ConsoleKey.D2:
                        sphereMethods = Sphere.Area;
                        break;
                    case ConsoleKey.D3:
                        sphereMethods = Sphere.Volume;
                        break;
                    case ConsoleKey.NumPad1:
                        sphereMethods = Sphere.Length;
                        break;
                    case ConsoleKey.NumPad2:
                        sphereMethods = Sphere.Area;
                        break;
                    case ConsoleKey.NumPad3:
                        sphereMethods = Sphere.Volume;
                        break;
                    default:
                        Console.WriteLine("Вы ввели недопустимый символ");
                        break;
                }
            }            
            Console.WriteLine($"Ответ:{sphereMethods?.Invoke(ReadValue("\nВведите значение радиуса:")):f2}");
            Console.ReadKey();
        }
        static double ReadValue(string text)   //метод проверяющий корректность ввода данных
        {
            double value;
            while (true)
            {
                Console.WriteLine(text);
                if (Double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Ввод некорректен");
                }
            }
        }
    }
    
}
