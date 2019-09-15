using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Constructor
    {
        int i; string s; bool b;
        static void Main ()
        {
            Constructor p = new FirstProject.Constructor(); // to define a new instance
            Console.WriteLine("Value of I is " + p.i);//If no value assigned then it calls the "implicit constructor" explicitly. The called constructor is known as default constructor
            Console.WriteLine("Value of b is : " + p.b);
            Console.ReadLine();
        }
    }
}
