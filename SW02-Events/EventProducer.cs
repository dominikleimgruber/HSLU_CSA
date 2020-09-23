namespace SW02_Events
{
    public class EventProducer
    {
        public event MyDelegate MyEvent;

        public void OnMyEvent(string data)
        {
            if (MyEvent != null)
            {
                MyEvent(this, new MyEventArgs(data));
            }
        }

    }
}