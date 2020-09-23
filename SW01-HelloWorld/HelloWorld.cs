using System;

namespace SW01_HelloWorld
{
    class HelloWorld
    {
        /**
         * Questions:
         * Where is the difference between release and debug?
         */
         private void PrintMessage(string message, bool toUpper)
        {
            if (toUpper)
            {
                message = message.ToUpper();
            }
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {

            HelloWorld hw = new HelloWorld();

            hw.PrintMessage("Hello World", false);
            hw.PrintMessage("Hello World", true);

        }
    }
}
