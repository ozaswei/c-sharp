using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace FirstProject
{
    class StringBuilder1
    {
        static void Main()
        {
            string s = "";
            Stopwatch sw = new Stopwatch(); // this stopwatch class is located at the System.Diagnostics namespace
            sw.Start();
            for(int i =1;i<=100000;i++)
            {
                s = s + i;
            }
            sw.Stop();
            Console.WriteLine("Time taken for the string:: "+sw.ElapsedMilliseconds);
            StringBuilder sb = new StringBuilder(10000);//StringBuilder is a pre-defioned class, so dont wirte the class name as same as it . 
            Stopwatch sw2 = new Stopwatch();            //(10000) is the initial capacity
            sw2.Start();
            for ( int i = 1; i <= 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time taken for the StringBuilder:: " + sw2.ElapsedMilliseconds);
            Console.ReadLine();
        }

    }
}
