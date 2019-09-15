using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Linq1
    {
        static void Main()
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            var brr = from i in arr where i > 40 orderby i descending select i; //brr will have the values greater than 40  in an descesnding order

            foreach(int i in brr)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();

        }
    }
}
