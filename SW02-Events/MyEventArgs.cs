using System;

namespace SW02_Events
{
    public class MyEventArgs : EventArgs
    {
        public string EventData { get; set; }

        public MyEventArgs(string eventData)
        {
            EventData = eventData;
        }
    }
}