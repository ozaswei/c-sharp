using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class GenericDelegates
    {
        public static double AddNums1(int x, float y, double z )
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine( x + y + z);
        }
        public static bool CheckLenght(string str)
        {
            if(str.Length>5)
                return true;
            return false;
        }
        static void Main()
        {
            //Using Func<>
            Func<int, float, double,double> obj1= AddNums1; // Func<inputparameters,result>instance=methodname
            double result = obj1.Invoke(1,1.24f,2.00); // for float value we should always write f at the last
            Console.WriteLine(result);

            //Using action
            Action<int, float,double>obj2 = AddNums2;//all are inputparamets only and the return is always void
            obj2.Invoke(1, 1.24f, 2.89);    //Action<inputparameters>

            //Using Predicate
            Predicate<string> obj3 =CheckLenght;//Predicate is for bool , input type u need to define but the ouput type is always bool
            bool status = obj3.Invoke("karren");//it will retyrn true

            //Using Func instead of Predicate
            Func<string, bool> obj4 = CheckLenght;//We can use Func delegate too but generally they ask us to use Predicate
            bool status2 = obj4.Invoke("Eden");//it will return false
            Console.WriteLine(status);
            Console.WriteLine(status2);


            Console.WriteLine();


            Console.WriteLine("Using Lambda expression");
            Func<int, float, double, double> obj5 = (x, y, z) =>
            {
                return x + y + z;
            };// here we need to write ;
            double result2 = obj5.Invoke(1,1.50f,2.50);
            Console.WriteLine(result2);

            Action<int, float, double> obj6 = (x, y, z) => Console.WriteLine(x + y + z); // we can also write it like this can its only single line of code
            obj6.Invoke(1, 1.50f, 2.50);

            Predicate<string>obj7=(str)=> // here there are multiple line of code ,so we cant write like above
                {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status3=obj7.Invoke("Kannon");
            Console.WriteLine(status3);
            Console.ReadLine();
        }
    }
}
//The predefined delegates are :- func,action and predicate. They are defined at the base class
