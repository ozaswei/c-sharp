using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public class Properties
    {
        double _Radius = 12.34;//_Radius is a proper method of declaring a variable
        public double GetRadius()
        {
            return _Radius;
        }
        public void SetRadius(double value)
        {
            _Radius = value;
        }
        public double Radius // we can set and get radius by this method
        {
            get{ return _Radius; } // it is readonly property. It represents a value returning method without parameter
            set
            {                     // it is read-write property. It represent a non-value returning method with parameter(implicitly declared).
                if(value>_Radius) // makign a condition that the new radius must alwasy be greater than the old one
                _Radius =value;
            }
        }
    }
    public class TestCircle
    {
        static double pi=3.14; 
        static void Main()
        {
            Properties a = new Properties();
            double r=a.GetRadius();
            Console.WriteLine("Area : "+pi*r*r);
            a.SetRadius(200);
            r = a.GetRadius();
            Console.WriteLine("Area : " + pi * r * r);
            //Using the radius property
            r = a.Radius;//no need brackets . Calling the get accessor
            Console.WriteLine("Radius Currently: " +  r);
            a.Radius=1;//Calling the set accessor
            r = a.Radius;
            Console.WriteLine("Radius now : " + r);
            Console.WriteLine("Area : " + pi * r * r);
            Console.ReadLine();
        }

    }
}
//Property is a combination of two methods
//_VariableName is the proper method for declaring a variable