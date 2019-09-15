using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject
{
    class First
    {
        public int x = 100;        
    }
    class Second
    {
        public int x=100;
        public Second(int x)
        {
            this.x = x; //this.x refers to the class variable x (that is the above public int x)
        }               // and the x at this.x=x refers to the local variable of x(that is the value of the above function public Second(int x))
        
    }

    class TestClasses
    {
        public static void Main()
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x + " ");
            Second g1 = new Second(100);// here the value 100 is firstly passed to the local variable x then passed to the class variable x
            Second g2 = new Second(200);
            Second g3 = new Second(300);
            Console.WriteLine(g1.x + " " + g2.x + " " + g3.x + " ");
            Console.ReadLine();

        }

    }
}
 // whenever we are defining a class ,first identify whether if the class variables requires some values to execute and if they are required then define a constructor explicitly and pass values through that constructor, so that everytime the instance of the class is created we get a chance of passing new values.
//Generally every class requires some values for execution and the values that are required for a class to executes are always sent to the class by using the constructor only.