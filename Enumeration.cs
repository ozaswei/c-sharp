using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public enum Days//default enum is integer
    {
        Monday=1,//Forcing index to start from 1
        Tuesday,
        Wednesday,
        Thursday=10,
        Friday
    }
    class Enumeration
    {
        public Days MeetingDay // Days is a userdefined datatypes
        {
            get; set;
        } = (Days)1;//setting a default meeting day, here as we have set 1 as the initial value so starting must be from 1

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hello World");
            Console.ResetColor();
            Days d = (Days)1;//Only the first value can be taken over by using 0
            Console.WriteLine(d);
            Days d2 = Days.Thursday;//we can write  it like this too;
            Console.WriteLine(d2);
            Console.WriteLine((int)d2);//Integer representation of the days
            foreach (int i in Enum.GetValues(typeof(Days)))//using foreach loop to get the integer values of days
                Console.WriteLine(i);
            foreach (string i in Enum.GetNames(typeof(Days)))//using loop to print all the days 
                Console.WriteLine(i);
            foreach (int i in Enum.GetValues(typeof(Days)))//using loop to print both days name and iits value
                Console.WriteLine(i+" : "+(Days)i);
            Enumeration p = new Enumeration();
            Console.WriteLine(p.MeetingDay);
            p.MeetingDay = Days.Friday;//setting the days from monday to friday
            Console.WriteLine(p.MeetingDay);
            Console.ReadLine();

        }
    }
}

//An enum is a user-defined type,so it is always better to define an enum direstly under the namespace but it is also possible to define an enum under a class or structure.
//Enums will come under value type category
//The first value can be printed without using (Days)
//GetValues returns an integer array
//GetNames retuns the string array
//supported options of it are byte,int,short,long,uint,ushort,ulong and sbyte
//to change the type just write -> public enum hello:byte {here you write codes}
//String is a pre-defined datatype