using System;
namespace Constructors
{
    public class ClassB : ClassA
    {
        public ClassB(string message, int count) : base(message)
        {
            Console.Write("B:" + message);

            for (int i = 0; i < count; i++)
            {
                Console.Write(".");
            }
            Console.Write(" ");
        }

        public ClassB(string message) : this(message, 1) { }

        public ClassB() : this("B0", 0) { }

    }
}
