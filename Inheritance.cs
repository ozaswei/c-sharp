using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Inheritance // this class isnt inheriting from anyone so it inherits from object class
    {
        public Inheritance()
        {
            Console.WriteLine("The parent class constructor that is Inheritance construtor  is called");
        }
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
//Inheritance is a mechanism of consuming the members of one class in another class by establishing parent child relationship between the classes which provides reusability. 
//1)In inheritance, the child class can consume the members of its parent class as if it is the owner of those members except private members of parent.
//2)Parent classes constructor must be accessible to child class otherwise inheritance wont be possible.
//3)In inheritance child class can access parent classes members but parent classes can never access any member that is purely defined under the child class.
//We can initialize a parent classes variable by using a child class instance to make it as a refrence so that the refernce will be consuming the memeory of child class instance but in this case also, we cannot call any pure child class members by using the refernce.
//Every class that is defined by us or pre-defined in the libraries of the language has a default parent class i.e. object class of system namespace, so the methods of the object class (i.e. Equals, GetHashCode, GetType, ToString) are accessible from anywhere.
//4)Types of inheritance::The no. of parent classes, a child classes a can have or a no. of child classes, a parent class can have.
//Accroding to C++,5 types of inheritance:: Single, Multi-level, Heirarchical, Hybrid and Multiple.
//5)In CSharp, we dont have support for multiple inheritance through classes. What we are provided is only single inheriteance through classes.
//So hybrid and multiple isn't supported.
//6) In the first point we learned ,whenever child class instance is created, class class constructor will implicitly call the parent class constructor but only if the constructor is parameterless whereas if the constructor of the parent class is parameterised, the child class cannot implicitly call the parent class constructor. So to overocome the problem it is the responsiblity of the programmer to explicitly call parent classes constructor from child class constructer and pass value to those parameters and very importantly to call parents constructor from child class we need to use the "base" keyword.
