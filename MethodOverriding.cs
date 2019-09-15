using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class MethodOverriding// Parent Class 
    {
        public void Show()
        {
            Console.WriteLine("Parents Show method is called");
        }
        public virtual void Test()//overridable
        {
            Console.WriteLine("Parents Test Method is called");
        }
    }
    class LoadChild:MethodOverriding
    {
        public void Show(int i)//overloading parents show methos in child class
        {
            Console.WriteLine("Child class Show method is called");
        }
        public override void Test() // child class overriding the parent class method 
        {
            Console.WriteLine("Child class Test method is called");
        }
        static void Main()
        {            
            LoadChild c = new LoadChild();
            c.Show();
            c.Show(10);
            c.Test();
            Console.ReadLine();
        }
    }
}
//MethodOverriding is an apprroach of re-implementing a parent classes method under the child class with the same signature.

//Difference Between :-
    //Overloading :
//-In this case we define multiple methods with the same name by changing their parameters.
//-this method can be perfomed either within a class as well as between parent child classses also.
//-While overloading a parent classes method under the child class, child class doesnt require to take any permission from the parent class.
//-Overloading is all about defining multiple behaviour to a method.
    //Overriding :
//-In this case we define multiple methods with the same name and same paramters.
//-This can be performed only between parent child classes but can never be performed within the same class.
//-While overriding a parent method under child class , child class requires a permission from its parent class.
//-Overriding is all about changing the behaviour of the parent's method under child class.

//If we want to override a parent method under the child class , first that method should be declared by using the virtual modifier in parent class.

//Any virtual method of the parent class can be overridden by the child class if required by using the override modifier.