using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Open_Closed_Right_Sample
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
