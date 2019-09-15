using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class CopyConstructor
    {
        int x;
        public CopyConstructor(int i) // parameterised constructor
        {
            x = i;
        }
        public CopyConstructor(CopyConstructor a) // copy constructors, it is also parameterised constructor
        {
            x = a.x; // a.x is the local copy of x of the above constructor
        }
        public void Display()
        {
            Console.WriteLine("The vlaue of x is : " + x);
        }
        static void Main()
        {
            CopyConstructor p = new FirstProject.CopyConstructor(10);
            p.Display();
            CopyConstructor p2 = new FirstProject.CopyConstructor(20);
            p2.Display();
            CopyConstructor p3 = new FirstProject.CopyConstructor(p);// used the instance p and copy contructor
            p3.Display();
            Console.ReadLine();
        }
    }
}
// multiple constructors can be define that is constructors can be overloaded
// the default, copy and parameterised constructors and instance constructors i.i not static