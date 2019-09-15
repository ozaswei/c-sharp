using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class MethodHiding // parent class
    {
        public virtual void Test1()//Overridable
        {
            Console.WriteLine("Test1 Method from parent class");
        }
        public void Test2()
        {
            Console.WriteLine("Test2 Method from parent class");
        }
    }
    class ChildClass:MethodHiding
    {
        public override void Test1()
        {
            Console.WriteLine("Test1 method of child class");//re-implementing 
        }
        public new void Test2()
        {
            Console.WriteLine("Test2 Method from child class");// this is Method Hiding 
        }
        public void ParentTest1() // calling parent method from parent class even after re-implementation
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        static void Main()
        {
            MethodHiding m = new MethodHiding();
            m.Test1();
            m.Test2();
            ChildClass c = new ChildClass();// it is an instance of child class
            c.Test1();
            c.Test2();
            c.ParentTest1();
            c.ParentTest2();
            MethodHiding p = c; //p is a refernce of parent class created by using childs instance.
            p.Test1();//Invokes child clases method
            p.Test2();//Invokes parent class method 
            Console.ReadLine();
        }
    }
}
//Method Hiding/Shadowing is also an approach of reimplementing a parent class method under the child class exactly with the same name and signature.
//In the method overriding , child class reimplements its parent classes methods which all declared as virtual, whereas at method hiding the calss can reimplement any parent method evenif the method is not declared as virtual.
//We can re-implement a parent class method under child class by using two approaches:-
    //1)Method overriding
    //2)Method Hiding

//After re-implementing parent classes methods under child classes , the child class instance will start calling the local methods only that is the reimplemented methods but if required in any case ,we can also call the parent classes methods from child classes by using two approaches:-
    //1)Directly create an instance of parent class in child class
    //2)By using the base keyword also ,we can call the parent method from child class but keywords like this and base cannot be used from static blocks.

//A parent class refernce evenif created by using the child class instance cannot access any members that are purely defined under the child class but can call overridden members of child class,because overiden memebers arent considered as pure child class methods but members which are reimplemented by using the approach of hiding are considered as pure class members and arent accessible to the parent refernces. 