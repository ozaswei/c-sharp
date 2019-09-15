using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class ParameterisedConstructor
    {
        int x;
        public ParameterisedConstructor(int i)
        {
            x = i; // assiging the value of x as i 
            Console.WriteLine("Parameterised constructor is called and the value of i is : " + i);
        }
        public void Display()
        {
            Console.WriteLine("The value of x is : " + x);
        }
        static void Main()
        {
            ParameterisedConstructor p = new FirstProject.ParameterisedConstructor(10);
            ParameterisedConstructor p2 = new FirstProject.ParameterisedConstructor(20);
            p.Display();// using the object p and calling the display function
            p2.Display();
            Console.ReadLine();
        }
    }
}
//Here 10 is the value of i
