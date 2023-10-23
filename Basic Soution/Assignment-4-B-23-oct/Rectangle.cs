using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_B_23_oct
{
    internal class Rectangle : Shape,IDrawable
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public override double CalaculatePerimeter()
        {
            double perimeter=2*(Length+Width);
            return perimeter;
        }

        public override double CalculateArea()
        {
           double areaOfRectangle=Length*Width;
            return areaOfRectangle;
        }

        public void Draw()
        {
            Console.WriteLine("This is Rectangle");
            Console.WriteLine(CalculateArea());
            Console.WriteLine(CalaculatePerimeter());
           
        }
    }
}
