using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecademy_C_Sharp_Architect_Arithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 4
            Console.WriteLine($"Rectangle Method Test: Length 4 & Width 5 = Area of {RectangleArea(4, 5)}");
            Console.WriteLine($"Circle Method Test: Radius 4 = Area of {CircleArea(4)}");
            Console.WriteLine($"Triangle Method Test: Base 10 & Height 9 = Area of {TriangleArea(10, 9)}");
            Console.WriteLine("\n");

            // 6
            double totalArea = RectangleArea(1500, 2500) + (CircleArea(375) / 2) + TriangleArea(750, 500);
            Console.WriteLine($"Total Area of Floor Plan = {totalArea}m");
            Console.WriteLine("\n");

            // 7
            decimal cost = Decimal.Round(Convert.ToDecimal(totalArea * 180), 2);
            Console.WriteLine($"Cost of Flooring Materials = {cost} Pesos");

            Console.ReadKey();
        }

        // 1
        public static double RectangleArea(double length, double width)
        {
            double area = length * width;
            return area;
        }

        // 2
        public static double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        // 3
        public static double TriangleArea(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
    }
}
