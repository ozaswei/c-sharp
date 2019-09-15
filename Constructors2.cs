using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Constructors2
    {
        int x; //it is a fields
        static int y;
        static Constructors2()
        {
            y = 10;
            Console.WriteLine("Static Construtor is called!!");
        }
        public Constructors2(int x)
        {
            this.x = x;
            Console.WriteLine("Non static Constructor or Instance constructor is called!!");
        }
        static void Main()
        {
            Console.WriteLine("The main method is called!!");
            Constructors2 p1 = new Constructors2(100);
            Constructors2 p2 = new Constructors2(200);
            Constructors2 p3 = new Constructors2(300);
            Console.WriteLine(y);// static member of the class can be directly accesed under a static block
            Console.WriteLine(p1.x+" "+p2.x+" "+p3.x);
            Console.ReadLine();
        }
    }
}
//Difference between static and non-static construtors:--------

//If a constructor is explicitly declared by using a static modifier then we call that constructor as static constructor whereas rest of the others are non-static constructors.

//Constructors are responsible for initializing the fields/variables of a class.

//static fields are initialized by static constructors and non staic fields are initialized by non static constructors.

//static constructors are implicitly called, whereas non-static construtors must be explicitly called.

//static constructor execute immediatly once the class executes and moreover its the first block of code to run under a class whereas non-static constructors executes only after creating the instance of class as well as each and everytime the instance of the class is created.

//In the lifecycle of a class, static construtor executes one and only one times whereas non-static constructors executes 0 times if no instances are created and n times if n instances are created.

//Non-static constructors can be parameterised but static constructors cannot have any parameters because they are implicitly called.

//Non-static construtors can be overloaded but not static constructors.

//Every class contains an implicit constructor if not defined explicitly and those implicit construtors are defined based on the following criteria:-
//1)every class except static class contains an implicit non-static constructor if not defined with any explicit constructor.
//2)Static constructors are implicitly defined only if the class contains any static fields or else the constructor will not be present at all.
//
