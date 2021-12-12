using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20
{
    class Sphere
    {
        public delegate double Methods(double radius);
        public const double PI = 3.1415926535897931;
        public static double Length(double radius)      //метод возвращает значение длины окружности большого круга сферы
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть нулевым или отрицательным значением");
            }
            else
            {
                return 2 * PI * radius;
            }
        }
        public static double Area(double radius)      //метод возвращает значение площади большого круга сферы
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть нулевым или отрицательным значением");
            }
            else
            {
                return Math.Pow(radius, 2) * PI;
            }
        }
        public static double Volume(double radius)      //метод возвращает значение объема шара
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть нулевым или отрицательным значением");
            }
            else
            {
                return Math.Pow(radius, 3) * PI * 4 / 3;
            }
        }
    }
}
