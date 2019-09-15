using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class AbsChild:AbsParent
    {
        public override void Mul(int x, int y)// The abstract classes abstract method should always be implemented by the child class.
        {
            Console.WriteLine(x*y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            AbsChild p = new AbsChild();
            AbsParent c = p; // c is the refernce of the instance child class 
            p.Add(100,100);
            p.Sub(100, 50);
            p.Mul(100, 100);
            p.Div(100, 100);
            c.Add(100,50);
            c.Sub(100,20);
            c.Mul(30,30);
            c.Div(40,40);
            Console.ReadLine();
        }
    }
}
