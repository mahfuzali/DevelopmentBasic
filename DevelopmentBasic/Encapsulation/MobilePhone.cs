using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentBasic.Encapsulation
{
    internal sealed class MobilePhone
    {
        private int networkConnectionQuality;    //let's say it is integer from 1 to 10
        private int batteryPercentage;           //shows in percents battery status from 1 to 100

        private readonly List<string> _callDataToLog = new List<string>();

        public string CurrentCaller { get; set; }

        public bool CallToPerson(string PersonsCellPhone)
        {
            //calling and return true
            AddCallDataToLog();
            return true;
        }
        public bool StopCurrentCall()
        {
            //stopping and return true
            return true;
        }
        public bool AnswerInputCall()
        {
            //answering and return true
            AddCallDataToLog();
            return true;
        }
        public void GetPhoneStatus(out int NetworkStatus, out int BatteryStatus)
        {
            NetworkStatus = networkConnectionQuality;
            BatteryStatus = batteryPercentage;
        }
        private void AddCallDataToLog()
        {
            //adds call data to log
            _callDataToLog.Add(CurrentCaller + " " + DateTime.Now);
        }
    }
}
