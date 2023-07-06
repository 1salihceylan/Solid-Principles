using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interface_Segregation_Wrong_Sample
{
    class Bird : IAnimal
    {
        public void bark()
        {
        }

        public void fly()
        {
        }

        public void run()
        {
        }
    }
}
