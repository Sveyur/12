using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Circle.length(radius);
            Circle.area(radius);
            Console.Write("\nВведите координату точки - x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату точки - y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Circle.own(radius, x, y);
            Console.ReadKey();
        }
        public class Circle
        {

            internal static void length(double radius)
            {
                double length = 2 * Math.PI * radius;
                Console.WriteLine("Длина окружности равна = {0}",Math.Round(length,2));
            }
            internal static void area(double radius)
            {
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("Площадь круга равна = {0}", Math.Round(area,2));
            }
            internal static void own(double radius, double x, double y)
            {
                double radius_xy = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                Console.WriteLine("Расстояние от центра круга до точки  = {0}", Math.Round(radius_xy,2));
                if (radius_xy <= radius)
                {
                    Console.WriteLine("Точка с координатами (x={0},y={1}) принадлежит кругу с координатами центра x0,y0",x,y);
                }
                else
                {
                    Console.WriteLine("Точка с координатами (x={0},y={1}) не принадлежит кругу с координатами центра x0,y0", x, y);
                }
            }


        }
    }
}
