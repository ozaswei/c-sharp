using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Inheritance4:Inheritance3
    {
        Inheritance4(int a):base(a) // a variable value can be passed
        {
            Console.WriteLine("This is the constructor of the class Inheritance4");
        }
        static void Main()
        {
            Inheritance4 c1 = new Inheritance4(20);
            Inheritance4 c2 = new Inheritance4(30);
            Console.ReadLine();
         }
    }
}
