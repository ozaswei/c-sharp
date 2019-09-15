using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class TestExtensionMethods
    {
        static void Main()
        {
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3(10);
            int i = 10;
            long a=i.Factorial();// we declared i as a int , so we can write i.Factorial();
            Console.WriteLine("Factorial of {0} is :: {1}",i,a);

            string str = "HelLo hOw aRe yoU";
            str = str.ToUpper();
            Console.WriteLine(str);
            str = str.ToProper();
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
