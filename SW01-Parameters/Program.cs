using System;

namespace SW01_Parameters
{
    class Program
    {
        public Program()
        {
            Test1();
            Test2();
            
        }
        private void Test1()
        {
            int a = 1; int b = 2; int c = 3; int d = 4; int e = 5;        
            Method1(out a, out b, out c, ref d, ref e);
            Console.WriteLine("a={0} b={1} c={2} d={3} e={4}", a, b, c, d, e);   
        }

        private void Method1(out int a, out int b, out int c, ref int d, ref int e)
        {
            a = 1 + 1;         
            b = 2;        
            c = 2 * d;        
            d = c + e;
        }

        private void Test2()
        {
            C a = new C();
            C b = new C();
            b.X = 2;
            C c = new C();
            c.X = 3;
            C d = new C();
            C e = c;
            
            Method2(out a, ref b, c, d, e);
            Console.WriteLine("a={0} b={1} c={2} d={3} e={4}",a.X, b.X, c.X, d.X, e.X);
        }

        private void Method2(out C a, ref C b, C c, C d, C e)
        {
            b = new C();        
            a = b;        
            c = b;        
            d = new C(); 
            d.X = 7;        
            e.X = 9;
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.ReadLine();
        }
    }

    public class C
    {
        public int X;
    }
}