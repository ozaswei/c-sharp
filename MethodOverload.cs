using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class MethodOverload
    {
        public void Test()
            {
            Console.WriteLine("1st Method without a parameter");
            }
        public void Test(string s)
        {
            Console.WriteLine("2nd Method with a string parameter");
        }
        public void Test(int i ,string s)
        {
            Console.WriteLine("3rd Method with an integer and string parameter");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("4th Method with a string and integer parameter");
        }
        public void Test(int i )
        {
            Console.WriteLine("5th Method with an integer parameter");
        }
        static void Main ()
        {
            MethodOverload p = new MethodOverload();
            p.Test();
            p.Test("Hello");
            p.Test(2,"Hello");
            p.Test("Hello", 2);
            p.Test(2);
            string s = "Hello World";
            int a, b, c;
            a=s.IndexOf('o');
            b=s.IndexOf('o',5);
            c=s.IndexOf("ll");
            Console.WriteLine(a+" "+b+" "+c+" ");
            Console.ReadLine();
        }
    }
}
//Method Overloading is a approach of defining multiple behaviour to a method.
