using System;

namespace SW02_Events
{
    
    //public delegate void MyDelegate(object sender, MyEventArgs e);

    class Program
    {
        
        public Program()
        {
            EventProducer producer = new EventProducer();
            EventConsumer consumer1 = new EventConsumer(producer);
            EventConsumer consumer2 = new EventConsumer(producer);
            producer.OnMyEvent("Event fired ... ");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.Read();
        }
    }
}