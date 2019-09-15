using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public delegate void RecDelegate(double width, double height);
    class Rectangle1
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area:: "+Width *Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter:: "+2 *(+Width+Height));
        }
        static void Main()
        {
            Rectangle1 r = new Rectangle1();
            RecDelegate obj = r.GetArea;//no need bracket
            obj+= r.GetPerimeter; //  here we performed a binding so we will get the two outputs
            obj.Invoke(10,10);
            Console.WriteLine();
            obj.Invoke(1,1); //one call ,two results 
            Console.ReadLine(); 

        }
    }
}
