using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public abstract class Abstract // it is a parent abstract class here 
    {
        public double w, h, r;
        public const float pi=3.14f; //for float always write 'f' at the last part of the value
        public abstract double GetArea();// once u declare an abstract method , your class automatically becomes a abstract class.
    }
    class Rectangle:Abstract
    {
        public Rectangle(double w,double h)
        {
            this.w = w;
            this.h = h;
        }
        public override double GetArea()
        {
            return w * h;
        }
    }
    class Circle:Abstract
    {
        public Circle(double r)
        {
            this.r = r;
        }
        public override double GetArea()
        {
            return pi*r*r;
        }
    }
    class Cone : Abstract
    {
        public Cone(double r,double h)
        {
            this.r = r;
            this.h = h;
        }
        public override double GetArea()
        {
            return pi * r * (r+Math.Sqrt(h+r*r));
        }
    }
    class Triangle:Abstract
    {
        public Triangle(double w, double h)
        {
            this.w = w;
            this.h = h;
        }
        public override double GetArea()
        {
            return (1 / 2) * w * h;
        }
    }
    class DisplayArea
    {
        static void Main()
        {
            Rectangle r = new Rectangle(2.34,3.34);
            Circle c = new Circle(2.34);
            Cone cone = new Cone(2.34,3.34);
            Console.WriteLine("Area of rectangle:: "+r.GetArea());
            Console.WriteLine("Area of circle:: " + c.GetArea());
            Console.WriteLine("Area of cone:: " + cone.GetArea());
            Console.ReadLine();
        }

    }     
}
//Abstract Method: A method without any method body is known as abstract method
//Abstract Class: A class which contains any abstract members in it 
//What the method contains is only the declaration of the method . E.g. :- public abstract void Add(int x,int y);
//If the method is declared as abstract under any class then the child class of the class is responsible for implementing the method without fail .
//The concept of abstract method will be near similar to the concept of method override.
//To define a method or class as abstracct we require to use the abstract keyword on them.
