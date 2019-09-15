using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class LambdaExpressions
    {
        static void Main()
        {
            GreetingsDelegate obj = (name) =>    //this is Lambda expression , We can write (string name) but its not mandetory
            {
                return "Hello " + name + ", A very Good morning";
            };
            string str=obj.Invoke("Karren");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
