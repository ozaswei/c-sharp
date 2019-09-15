using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    interface ITestInterface
    {
        void Add(int a, int b);       
    }
    interface ITestInterface2:ITestInterface
    {
        void Sub(int a, int b);
    }
    class ImplementationClass:ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a , int b)//or you can also write like this void ITestInterface2.Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void Main()
        {
            ImplementationClass obj = new ImplementationClass();
            ITestInterface2 i = obj;//i is a parent refernce created by using a child instance
            obj.Add(1, 2);
            obj.Sub(6, 3);
            i.Add(2, 2);//we can create a refernce and call it through it 
            i.Sub(10, 6);
            Console.ReadLine();
        }
      
    }
}
//Class- Non-abstract methods(methods with method body only)
//Abstract class - containing Non-abstract class and abstract class
//Interface - It is a userdefined type like a class that contains only Abstract methods(methods without method body)
//Every abstract method of an interface should be implemented by the child class of the interface 
//Generally a class inherits from another class to consume the members of its parent whereas if a class is inheriting from an interface it is to implement the members of it s parent.
//A class can inherit from a class and interface both at a time .
//the default scope for the members of an interface is public whereas its private incase of a class.
//by default every member of an interface is abstract, so we dont require to use abstract modifier on it again just like we do in case of abstract class.
//We cannot decalre any fields/variables under an interface.
//If required an interface can inherit from another interface.
//Every member of an interfacce should be implemented under the child class without fail but while implementing , we dont require to use override modifier just like we have done incase of abstract class.
//Evenif multiple inheritance is not supported through classes in Csharp , it is still support through interfaces.
//A class cna have one and only one immediate parent whereas the same class can have any number of interfaces as its parents i.e. multiple inheritance is support in Csharp through interfaces.