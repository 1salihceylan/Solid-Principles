using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Liskov_Substitution_Right_Sample
{
    public class Ferrari : Car, IAirConditionable
    {
        public override string Run()
        {
            return "Ferrari için araba çalıştı.";
        }

        public string OpenAirConditioning()
        {
            return "Klima açıldı.";
        }
    }
}
