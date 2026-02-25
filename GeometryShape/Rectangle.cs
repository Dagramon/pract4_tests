using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) 
        { 
            try
            {
                this.width = width;
                this.height = height;
                if (height <= 0 || width <= 0)
                    throw new ArgumentException("Стороны не могут быть отрицательными");

            } catch
            {
                throw new ArgumentException("Неккоректно введены данные");
            }
        }

        private double width { get; set; }
        private double height { get; set; }
        public override double Area()
        {
            return width * height;
        }
        public override double Perimeter()
        {
            return (height * 2) + (width * 2);
        }
        public override string ToString()
        {
            return $"Ширина: {width}\nВысота: {height}";
        }
    }
}
