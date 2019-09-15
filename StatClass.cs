using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    static class StatClass // to bind the class , the class which we are going to bind must be static
    {// every method we define in a static class must me static
        public static void Test3(this Program p,int i) // this Program.p means the method test3 belongs to program class
        {                                          //So we binded it with the Program class using the 'this' keyword
            Console.WriteLine("Method 3 :: "+i);          //p is just a variable
        }
        public static long Factorial(this Int32 x) // the vlaue of 'i' in class TestExtensionMethod is accessible to me through 'x'. 
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1); // using recursive method 
        }
        public static string ToProper(this string OldStr)
        {
            String NewStr = null;
            String NewStr2 = null;
            if (OldStr.Trim().Length>0)
            {
                OldStr = OldStr.ToLower();//it converts all to lowercase.
                string[] StrArray=OldStr.Split(' '); // this will split the words when it comes across a space now and it returns each and every word in a form of string array
                foreach(string str in StrArray)// here the str stores the value that came from StrArray
                {
                    char[] CharArray= str.ToCharArray(); // this method will break the string into a character Array
                    CharArray[0] = char.ToUpper(CharArray[0]);//it converts the first character to uppercase
                    NewStr = new string(CharArray); // This converts the char to string
                    NewStr2 += NewStr + " "; // combning the strings with spaces
                }
                return NewStr2;
            }
            return OldStr;
        }
    }
    
}

//Exentension Methods::
//This is a new feature added in Csharp3.0
//It is a mechanism of adding new methods into an existing class or structure also without modifying the source code of the original type and in this process we dont require any recompilation.
//Extension methods are defined as static but once they are bound with any class or structure , it turns into non-ststic . That is why we are able to call it with an instance.
//If an extension method is defined with the same name and signature of a existing method in the class then extension method will not be called and the prefernce always goes to the original method only. 
//The first parameter of an extension method should be a name of the type to which the method has to be bound and this parameter is not taken into consideration while calling the extension.
//An extension method should have one and only one binding parameter and it should be in the first place of the parameter.
//Note::If an extension method is defined with n parameters then while calling it there will be n-1 parameters only because the binding paramter is excluded.
//