using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Instances
    {
        int x = 100;
        static void Main()
        {
            Instances f; // f is the variable of the class
            f = new FirstProject.Instances();// f is the instance of class
            //or just write Instances f=new FirstProject.Instances();
            Instances f2 = new FirstProject.Instances();
            Console.WriteLine(f.x+" "+f2.x);
            f.x = 200;
            Console.WriteLine(f.x + " " + f2.x);
            f2.x = 300;
            Console.WriteLine(f.x + " " + f2.x);
            Instances f3=f; // f3 is the refernce of the class that is the pointer to the f.So, f3 and f consumes the same memory.    
            Console.WriteLine(f.x + " " + f2.x+" "+f3.x);
            f3.x = 400;
            Console.WriteLine(f.x + " " + f2.x + " " + f3.x);
            Console.ReadLine();

           }
    }
}
//memeory allocation is done only after creating an instance.
//instances can be created using the "new" keyword.
//A class is a user--defeined type.
//A variable of a class is a copy of the class that is not initialized.
//A instance of a class is a copy of a class that is initialized by using the "new" keyword which has its own memory and never shared with another instance.
//Reference of a class is a copy of the class that is initialized by using an exisitng instance and references of a class will not have any memory allocation, they will be sharing the same memory of the instance that is assigned for initializing the variable.  
//any modification on an instances wont effect the other instance.
//every instance is unique of itself.
//variables cant be used for calling the members but references can be used for calling.
//reference wont have any memory allocation.
//Every modification we perform on the members using instance reflects when we access those members through refrence and vise-versa.
