using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Dependency_Inversion_Right_Sample
{
    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            //Send sms
        }
    }
}
