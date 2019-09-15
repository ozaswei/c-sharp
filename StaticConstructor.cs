using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("This is the static constructor");
        }
        static void Main()
        {
            Console.WriteLine("Main method is executed");
        }
    }
}
//If a calss contains any static variables, then only implicit static constructor will be present or else whereas non static constructorsa will be implicitly defined in every class ( except static class) provided we didnot define them explicitly.
//Static constructors are responsible for initializing static variables and these constructors and never called explicitly i.e. they are called implicitly and these construtors are the first to execute in a class. 
// non-static constructors must be explicitly called.
//static constructors cannot be parameterised. Overloading of static constructor isnt possible.
//static constructors are always called first. 