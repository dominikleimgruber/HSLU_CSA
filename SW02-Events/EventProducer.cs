using System;

namespace SW02_Events
{
    public class EventProducer
    {
        public event EventHandler<MyEventArgs> MyEvent;

        public void OnMyEvent(string data)
        {
            MyEvent?.Invoke(this, new MyEventArgs(data));
        }

    }
}