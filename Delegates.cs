using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    //step 1 :: defining a delegate
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string str); 
    public class Delegates
    {
        public void AddNum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)//this method is a static method
        {
            return "Hello " + name;
        }
        static void Main()
        {
            Delegates p = new Delegates();
            p.AddNum(20,30);
            string str = SayHello("Karren");//as SayHello is a static method,so calling by using the appropirate name of the class
            Console.WriteLine(str);

            //2) Instantiating the delegate
            Console.WriteLine();
            Console.WriteLine("Calling using the delegate");
            AddDelegate ad = new AddDelegate(p.AddNum); // It isnt a static class ,so we need to class the method by using the instance p
            SayDelegate sd = new SayDelegate(SayHello); // the method SayHello is static method 
            ad(20,30);
            ad.Invoke(10, 10); // or we can use it like this
            str = sd("Karren");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
//A delegate is a value type.
//A delegate is a type safe function pointer. 
//A delegate holds a refernce of a method and calls the method for execution.
