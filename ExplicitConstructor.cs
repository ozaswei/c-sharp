using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class ExplicitConstructor
    {
        public ExplicitConstructor() // default constructor or parameterless constructor. 
        {
            Console.WriteLine("Constructor is called");
        }
        static void Main()
        {
            ExplicitConstructor p1 = new FirstProject.ExplicitConstructor();// how many times we create an instance, that many times the constructor will be called
            ExplicitConstructor p2 = new FirstProject.ExplicitConstructor();
            ExplicitConstructor p3 = new FirstProject.ExplicitConstructor();
            Console.ReadLine();
        }
        //defining can be implicit or explicit
        // calling can only be explicit, that is if your dont call the constructor explicitly then the execution doesnt takes place.
        //implicit constructors are always parameterless
    }
}
