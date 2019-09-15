using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Variables
    {
        int x;//non-static variable
        static int y=200;// static variable
        const float pi=3.14f;// as here pi is initially double ,so we put f at the end of value to change it to float.
        readonly bool flag; // readonly variable
        public Variables(int x,bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main()
        {
            int z=300;// static variable
            Console.WriteLine(y);
            Console.WriteLine(pi);
            Variables p1 = new FirstProject.Variables(100,true);
            Variables p2 = new FirstProject.Variables(200,false);
            Console.WriteLine(p1.x+" "+p2.x);
            Console.WriteLine(p1.flag+" "+p2.flag);
            Console.ReadLine();

        }
    }
}
//Types of variables:- Non-static , static, constant, readonly
//If a variable is explicitly declared by using the static modifier orelse if a variable is declared under any static block then those variables are static whereas rest of the other are non-static.
//static memebers of the class doesnt require the instance of the class for initialization or execution whereas non-static  members of a class those.
//Static variables of a class are initialized immediately once the execution of class starts whereas instance variables are initialized only after creating a class instance as well as each and everytime the instance of class is created.
// In the lifecycle of the class static variable is initizlized one and only one time wheras instances variables are initialized for 0 times if no instances are created and n times if n instances are created.
//Initialization of instance or non-static variable is accosiated with instance creation and constructor calling, so instance or non-static variable can be insitialized through the constructor also.
// static variables overwrites the initial value if changed to certain value.
//If a variable is declared by using the keyword "const", we call it as a constant variable and these constant variables cannont be modified once after they get declared,so its a must to initialized constant variables at the time of declaration only.
//The behaviour of constant variable will be similar to that of the static variables that is initialized one and only one time in the lifecycle of a class and doesnt require the instance of class for accessing or initializing.
//The only differnce between the static and cnstant variables is that the static variables can be modified but not constant variables.
//If a variable is declared by using readonly keyword, we call that variable as a readonly variable and these variables also cannot be modified like constant variable but after initialization i.e. it isnt compulsory to initialize a readonly variable at the time of declaration,so they can be assigned later. They can also be initialized under the constructor.
//The behavior of readonly variable will be similar to that of the non-static variable that is initiazed only after the creation of instances of class and once per each instance of the class created.
//The only difference between readonly and instance variables is that instance variables can be modified but not readonly variables.
//Constant variable is a fixed value for the whole class whereaas Readonly variable is fixed value speciic to an instance of class.
