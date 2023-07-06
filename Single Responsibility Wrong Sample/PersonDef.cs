using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Single_Responsibility_Wrong_Sample
{
    public class PersonDef
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string IdentificationNumber { get; set; }


        public void PersonAdd()
        {
            //kişi ekleme metodu
        }

        public void PersonList()
        {
            //kişi listeleme metodu
        }
    }
}
