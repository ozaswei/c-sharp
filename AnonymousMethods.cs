using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethods
    {
        public static string Greetings(string name )
        {
            return "Hello " + name + ", a very good morning.";
        }
        static void Main()
        {
            GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            GreetingsDelegate obj2 = delegate (string name) // This method is anonymous method. We can use this method too
            {
                return "Hello " + name + ", a very good morning.";
            };
            string str=obj.Invoke("Karren");
            Console.WriteLine(str);
            Console.WriteLine();
            str = obj2.Invoke("Kannon");
            Console.WriteLine(str);
        }

    }
}
//Anonymous method is not suggested for big volumes of codes. Its advantage is lesser typing work.