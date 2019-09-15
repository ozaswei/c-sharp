using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    struct  Structures
    {
        int i;
        public Structures(int i)
        {
            this.i = i;
        }
        public void Display()
        {
            Console.WriteLine("Method of this class"+" "+i);
        }
        static void Main()
        {
            Structures p;
            p.i = 10;//explicitly initialized if we dont use new keyword in structure as it wont call the constructor
            p.Display();
            Structures p2 = new Structures();// this will use the default constructor
            p2.Display();
            Structures p3 = new Structures(30);//this is also another way of initializing the value 
            p3.Display();
            Console.ReadLine();
        }
    }
}
//Structure is a user-defind type
//Structures in C-language can contain only fields, whereas structures in CSharp can contain most of the members what a class can contain like fields, methods, constructors, properties, indexes, operator methods,etc.
//Differences between class and structure:-
//1) calss is a refernce type whereas structure is a value type.
//2)memory allocation for instances of class is performed on managed heap whereas memory allocation instances of structure is performed on Stack .
//3)We use classes for representing an entity with larger volumes of data whereas we use structures for representing smaller volumes of data
//Note:: All predefined datatypes under the libraries of our language which come under reference type catogery ,eg- string and object are pre-defined classes whereas all the pre-defined data types which come under the value type category, like int(Int32),Float(Single),bool(Boolean) or structures.
//4) in case of a class the new keyword is mandatory , whereas incase of structure its only optional.
//5)Fields of a class can be initialized at the time of declaration, whereas its not possible in the case of structure.
//Note:: If the structure contains any fields then we need to initialize those field either explicitly calling the default constructor or else if we arent using new keyword for creating the instance ,we need to explicitly assign the value to the field through refering it through the instance and assign the value .
//6) We can define any construtor under the class that is either parameterless or parameterized, and f no construtor is defined then there will be an implicit constructor which is default whereas incase of a structure , parameterles or default constructor is always implicit and cannot be defined explicitly , what we can define is only parameterized constructor.
//7)If zero constructors are defined in a class ,after compilation there will be one construtor (implicit) and if we define n constructors in a class , after compilation there will ne n constructors only whereas incase of a structure, if we define zero construtors then after compilation there will be 1 constructor (implicit), and if we define n constructors ,after compilation there will be n+1 construtors.
//8) class can be inherited by other classes whereas structures cannot be inherited by other structures thats is structure doesnt support inheritance.
//9) a class can implement an interface ,so can a structure. 
