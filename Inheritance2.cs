using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Inheritance2:Inheritance // here the class2 class is inheriting the methods of the parent class Inheritance
    {
        Inheritance2()// if no modifiers are specified then in default it will be private
        {
            Console.WriteLine("The child class construtor that is Inheritance2 constructor is called");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            Inheritance2 c = new FirstProject.Inheritance2();
            c.Test1();
            c.Test2();
            c.Test3();
            Inheritance c2 = new FirstProject.Inheritance();// creating the instance of parent class
            c2.Test1();
            c2.Test2();
            Inheritance c3; // here c3 is a variable of parent class "Inheritance"
            Inheritance2 c4 = new FirstProject.Inheritance2(); // here c4 is an instance
            c3 = c4; // c3 is a reference of parent class created by using child class instance
            c3.Test1();
            c3.Test1();
            Object obj = new Object();
            Console.WriteLine(obj.GetType());
            Inheritance c5 = new Inheritance();
            Console.WriteLine(c5.GetType());
            Inheritance2 c6 = new Inheritance2();
            Console.WriteLine(c6.GetType());
            Console.ReadLine();
        }
    }
}
//class2 class behaves as if it has 3 methods evenif it has only one but class Inheritance has 2 methods
//Whenever an instances is created in the child class, then the child class constructor will implicitly call the parent class construtor because its the rule.
//Child class always calls the parent class construtor first.
//We can initialize the parent class variable by using the child class instance