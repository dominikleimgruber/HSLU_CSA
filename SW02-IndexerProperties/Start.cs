using System;

namespace SW02
{
    class Program
    {
        static void Main(string[] args)
        {
            StringList sl = new StringList(); // Int-Property (setzt die Grösse der Liste)
            sl.Size = 5;
            Console.WriteLine("Size: " + sl.Size);// Zugriff auf Array über (Array-)Property
            sl.Data[1] = "Some value";
            sl.Data[3] = "Another value";
            foreach (string s in sl.Data)
            {
                Console.WriteLine("entry: " + s);
            }
            Console.WriteLine();// Zugriff auf Array über Indexer
            sl[4] = "Something else";
            sl[0] = sl[1] + ", " + sl[3];
            for (int i = 0; i < sl.Size; i++)
            {
                Console.WriteLine("entry[" + i + "]: " + sl[i]);
            }
            Console.Read();
        }
    }
}
