using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public class Employee
    {
        int Eno;
        string Ename,Job,Dname,Location;
        double Salary;
        public Employee(int Eno,string Ename, string Job, string Dname, string Location,double Salary)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
            this.Salary = Salary;
        }

        public object this[int index] //we used object as a type because we are three types that is integer, string and double .So, an object type can return any type of value
        {                               //using index by integer
            get // returning values
            {
                if (index == 1)
                {
                    return Eno;
                }
                else if(index ==2)
                {
                    return Ename;
                }
                else if (index == 3)
                {
                    return Job;
                }
                else if (index == 4)
                {
                    return Dname;
                }
                else if (index == 5)
                {
                    return Location;
                }
                else if (index == 6)
                {
                    return Salary;
                }
                else
                {
                    Console.WriteLine(":: Invalid number:: ");
                    return null;
                } 
            }

            set // assigning values
            {
                if (index == 1)
                {
                   Eno = (int)value;
                }
                else if (index==2)
                {
                    Ename = (string)value;
                }
                else if (index == 3)
                {
                    Job = (string)value;
                }
                else if (index == 4)
                {
                    Dname = (string)value;
                }
                else if (index == 5)
                {
                    Location = (string)value;
                }
                else if (index == 6)
                {
                    Salary = (double)value;
                }
            }
        }
        public object this[string name] //using index by string
        {
            get
            {
                if (name.ToUpper() == "ENO")//converting to uppercase
                {
                    return Eno;
                }
                else if (name.ToUpper() == "ENAME")
                {
                    return Ename;
                }
                else if (name.ToUpper() == "JOB")
                {
                    return Job;
                }
                else if (name.ToUpper() == "DNAME")
                {
                    return Dname;
                }
                else if (name.ToUpper() == "LOCATION")
                {
                    return Location;
                }
                else if (name.ToUpper() == "SALARY")
                {
                    return Salary;
                }
                else
                {
                    Console.WriteLine(":: Invalid number:: ");
                    return null;
                }
            }
            set
            {
                if (name.ToUpper() == "ENO")
                {
                    Eno = (int)value;
                }
                else if (name.ToUpper() == "ENAME")
                {
                    Ename = (string)value;
                }
                else if (name.ToUpper() == "JOB")
                {
                    Job = (string)value;
                }
                else if (name.ToUpper() == "DNAME")
                {
                    Dname = (string)value;
                }
                else if (name.ToUpper() == "LOCATION")
                {
                    Location = (string)value;
                }
                else if (name.ToUpper() == "SALARY")
                {
                    Salary = (double)value;
                }
            }
        }

        }
}
