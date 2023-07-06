using ConsoleApp1.Liskov_Substitution_Wrong_Sample;
using ConsoleApp1.Open_Closed_Right_Sample;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Open/Close
            Rectangle rec = new Rectangle(3, 5);
            Circle circle = new Circle(5);

            Shape[] shapes = new Shape[2];
            shapes[0] = rec;
            shapes[1] = circle;

            AreaCalculator calculator = new AreaCalculator();

            Console.WriteLine(calculator.Area(shapes));

            Console.Read();
            #endregion



            #region Liskov
            Car car = new Ferrari();

            car.Run();
            car.OpenAirConditioning();
            // OK

            car = new Murat131();

            car.Run();
            car.OpenAirConditioning(); // NOT OK 
            #endregion
        }
    }
}
