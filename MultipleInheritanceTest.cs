using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    interface Interface1
    {
        void Test();
        void Show();
    }
    interface Interface2
    {
        void Test();
        void Show();
    }

    class MultipleInheritanceTest:Interface1,Interface2
    {
        public void Test() // it implemented the method so the interface 1 and 2 are both satisfied, as interface 1 and 2 dont know that they have same method.
        {
         Console.WriteLine("Interrface implemented in child class");
        }
        void Interface1.Show() // no modifiers pls 
        {
            Console.WriteLine("Declared in interface1 and implemented in class");
        }
        void Interface2.Show()// dont put modifiers here
        {
            Console.WriteLine("Declared in interface2 and implemented in class");
        }

        static void Main()
        {
            MultipleInheritanceTest p = new MultipleInheritanceTest();
            p.Test();
            Interface1 i1= p;//here for explicity implementation , u cannot call by using child class instance, so u need to create a reference of that interface and with that refernce we need to call it.
            Interface2 i2 = p;//like here we created a refernce
            i1.Show();
            i2.Show();
            Console.ReadLine();
        }
    }
}
//Ambiguity error happens only when you are consuming not implementing
//Multiple inheritance is supported in interface.
