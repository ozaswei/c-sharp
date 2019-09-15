using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Matrix:Object // as parent class for Matrix is always Object
    {
        public int a, b, c, d;
        public Matrix(int a , int b, int c,int d) // constructor
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override string ToString() // overriding the parent Method Object class 
        {
            return a+" "+b+"\n"+c+" "+d+"\n";
        }
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a + obj2.a , obj1.b + obj2.b , obj1.c + obj2.c , obj1.d + obj2.d);
            return obj; 
        }
        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }
    }
    class TestMatrix
    {
        static void Main()
        {
            Matrix m1 = new Matrix(1,2,3,4);
            Matrix m2 = new Matrix(5,6,7,8);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.ReadLine();
        }
    }
}
