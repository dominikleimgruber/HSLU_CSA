using System;

namespace SW01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Hello World", true);
        }

        static void PrintMessage(String msg, bool toUpper)
        {
            if (toUpper)
            {
                msg = msg.ToUpper();
            }
            Console.WriteLine(msg);
        }
    }
}
