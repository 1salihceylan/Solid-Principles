using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Liskov_Substitution_Wrong_Sample
{
    public class Murat131 : Car
    {
        public override string Run()
        {
            return "Ferrari için araba çalıştı.";
        }

        public override string OpenAirConditioning()
        {
            throw new NotImplementedException();
        }
    }
}
