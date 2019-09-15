using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    //Defining our own Exception class

    public class DivideByOddNoException : System.ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by odd number";
            }

        }
        
        
    }
    class ApplicationException
    {
        static void Main()
        {
            Console.Write("Type the first number");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Type the second number");
            int y = int.Parse(Console.ReadLine());
            if (y % 2 != 0) // this will find the reminder
            {
                throw new System.ApplicationException("Divisor Value cannot be odd number");
            }
            int z = x / y;
            Console.WriteLine("The result of division of {0} from {1} is :: {2}", x, y, z);
            Console.WriteLine("End of the program");
        }
        }
}
