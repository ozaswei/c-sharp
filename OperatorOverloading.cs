using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class OperatorOverloading
    {
        static void Main ()
        {
            string s1 = "Hello";
            string s2 = "World";
            Console.WriteLine(s1+" "+s2);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 != s2);
            Console.ReadLine();
        }
    }
}
//Operator overloading is also an approach of defining multiple behaviour to an operator and those behaviour will vary based on the operand types between which the operator is used.
//Example of operator overloading:- Number + Number = addition 
//                                  String + String = concatenation
//For addition ---- public static int operator +(int a, int b)
//For substraction ---- public static int operator -(int a , int b)
//For finding the greater number ---- public static bool operator >(int a , int b) ->bool because it returns true or false.
//For concatenate two strings ---- public static string operator +(string a, string b)
//For comparing if two strings are equal ---- public static bool operator ==(string a , string b) -> Bool because it returns true or false.
//For comparing if two strings aren't equal ---- public static bool operator !=(string a, string b)  