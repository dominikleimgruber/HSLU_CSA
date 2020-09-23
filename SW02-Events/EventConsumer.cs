using System;

namespace SW02_Events
{
    public class EventConsumer
    {
        public EventConsumer(EventProducer producer)
        {
            producer.MyEvent += EventHandler;
        }
        
        public void EventHandler(object sender,MyEventArgs evt)
        {
            Console.WriteLine(evt.EventData);
        }
    }
}