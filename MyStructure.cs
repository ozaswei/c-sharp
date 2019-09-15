using System;
namespace FirstProject
{
    class Mystruc
    {
        public void Display()
        {
            Console.WriteLine("Method in the structure");
        }
        static void Main()
        {
            Mystruc p = new Mystruc();
            p.Display();
        }
    }
}