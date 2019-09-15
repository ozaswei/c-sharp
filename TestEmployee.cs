using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class TestEmployee
    {
        static void Main()
        {
            Employee emp = new Employee(1001,"Karren","Manager","Sales","Kathmandu",20000.00);
            Console.WriteLine("Employee No. :: " + emp[1]);//accessing by integer
            Console.WriteLine("Employee Name :: " + emp[2]);
            Console.WriteLine("Employee Job :: " + emp[3]);
            Console.WriteLine("Employee's Deparment Name :: " + emp[4]);
            Console.WriteLine("Employee Location :: " + emp[5]);
            Console.WriteLine("Employee Salary :: " + emp[6]);
            emp[3] = "Senior Manager";
            emp[6] = 25000.00;
            emp["location"] = "Lalitpur";
            Console.WriteLine();//break line
            Console.WriteLine("Employee No. :: " + emp["Eno"]);
            Console.WriteLine("Employee Name :: " + emp["Ename"]);
            Console.WriteLine("Employee Job :: " + emp["Job"]);
            Console.WriteLine("Employee's Deparment Name :: " + emp["Dname"]);
            Console.WriteLine("Employee Location :: " + emp["Location"]);
            Console.WriteLine("Employee Salary :: " + emp["Salary"]);
            Console.ReadLine();
        }
    }
}
