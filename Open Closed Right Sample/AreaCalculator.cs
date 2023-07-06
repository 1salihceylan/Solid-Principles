using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Open_Closed_Right_Sample
{
    public class AreaCalculator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
