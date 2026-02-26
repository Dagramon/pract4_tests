using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c) 
        {
            try
            {
                sideA = a;
                sideB = b;
                sideC = c;
                if (
                    (a + b < c) ||
                    (a + c < b) ||
                    (b + c < a)
                    )
                {
                    throw new ArgumentException("Неккоректные входные данные для треугольника");
                }
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArgumentException("Стороны не могут быть отрицательными или меньше нуля");
                }
            } catch
            {
                throw new ArgumentException("Неккоректные входные данные");
            }
        }
        private double sideA { get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }
        public override double Area()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p *(p-sideA)*(p-sideB)*(p-sideC));    
        }
        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }
        public override string ToString()
        {
            return $"Сторона A: {sideA}\nСторона B: {sideB}\nСторона C: {sideC}";
        }
    }
}
