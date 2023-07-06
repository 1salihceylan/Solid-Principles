using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interface_Segregation_Right_Sample
{
    class Dog : IAnimal, IBarkable, IRunnable
    {
        public void bark()
        {
       
        }

        public void live()
        {
           
        }

        public void run()
        {
            
        }
    }
}
