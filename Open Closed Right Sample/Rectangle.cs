using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Open_Closed_Right_Sample
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
