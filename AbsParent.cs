using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x-y);
        }
        public abstract void Mul(int x , int y);
        public abstract void Div(int x, int y);      
    }

}
