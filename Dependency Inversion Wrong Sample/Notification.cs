using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Dependency_Inversion_Wrong_Sample
{
    public class Notification
    {
        private Email _email;
        private SMS _sms;
        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
