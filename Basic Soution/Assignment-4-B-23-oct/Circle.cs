using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_B_23_oct
{
    internal class Circle : Shape,IDrawable
    {
        public double Radius {  get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalaculatePerimeter()
        {
            double perimeter = 2 * 3.144 * Radius;
            return perimeter;
           
        }

        public override double CalculateArea()
        {
            double area = 3.144*Radius*Radius;
            return area;
           
        }
        public void Draw()
        {
            Console.WriteLine("This is circle");
            Console.WriteLine(CalculateArea());
            Console.WriteLine(CalaculatePerimeter());

        }
    }
}
