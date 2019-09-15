using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public class Customer
    {
        int _Cusid;         //int is a structure
        bool _Status;       //bool is a structure
        string _Cname,_State;      //string is a class
        double _Balance;    //double is a structure
        Cities _City;       // now Cities here is a user-defined datatype

        public Customer(int Cusid,bool Status,string Cname,double Balance,Cities City,string State,string Country)
        {
            this._Cusid = Cusid;
            this._Status = Status;
            this._Cname = Cname;
            this._Balance = Balance;
            this._City = City;
            this._State = State;
            this.Country = Country;// the this.country is refering to the property of the Country
        }
        public string Country // Auto implemented or Automatic Property, a property without any field
        {
            get; // An automatic property must have both get and set 
        } = "Nepal"; //These are called Auto property initializer
        public string State
        {
            get { return _State; }
            protected set { //using set as protected , so it can only be accessed by chhild class
                if (_Status == true)
                    _State = value;
                }
        }
        public Cities City
        {
            get { return _City; }
            set {
                if (_Status == true)
                    _City = value;
                }
        }
        public int Cusid
        {
            get{ return _Cusid; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set {
                if(_Status==true)//putting a condtion that the Cname can be modified only when the status is true
                _Cname = value;
                }
        }
        public double Balance
        {
            get { return _Balance; }
            set {
                if(_Status==true)
                if(value>=500)
                _Balance = value;
                }
        }

    }
    public class TestCustomer
    {
        static void Main()
        {
            Customer a = new Customer(101,false,"Karren",5000.00,Cities.Kathmandu,"Pokhara","Nepal");
            Console.WriteLine("Customer Id :: "+ a.Cusid);//a.Cusid is readonly


            if (a.Status == false)//a.Status is read and writeable
            {
                Console.WriteLine("Customer current status:: Inactive"); 
            }
            else
            {
                Console.WriteLine("Customer current status:: Active"); 
            }

            Console.WriteLine("Current Customer Name:: " + a.Cname);// a.Cname is read and writeable
            a.Cname += " Logic"; // Modification is done only if the status is true. Also a.Cname+=" Logic" bhaneko a.Cname=a.Cname +" Logic" ho
            Console.WriteLine("Modified Customer Name:: " + a.Cname);

            Console.WriteLine("Customer current Balance:: " + a.Balance);//a.Balance is read and writable
            a.Balance -= 2000;//this modification is applied only if the status is true
            Console.WriteLine("Customer later Balance:: " + a.Balance);

            Console.WriteLine("Current City of Customer :: "+a.City);
            a.City = Cities.Lalitpur;
            Console.WriteLine("Modified City of Customer:: " +a.City);

            Console.WriteLine("Current State of Customer :: " + a.State);
            //a.State = "Kathmandu"; this cant be done if the Set part of the State is protected
            Console.WriteLine("Modified State of Customer :: " + a.State);

            Console.WriteLine("Current Country of Customer :: " + a.Country);
            Console.WriteLine(" ");



            //Now keeping status is true
            a.Status = true;
            if (a.Status == false)//a.Status is read and writeable
            {
                Console.WriteLine("Customer current status:: Inactive");
            }
            else
            {
                Console.WriteLine("Customer current status:: Active");
            }

            Console.WriteLine("Current Customer Name:: " + a.Cname);// a.Cname is read and writeable
            a.Cname += " Logic"; // Modification is done only if the status is true. Also a.Cname+=" Logic" bhaneko a.Cname=a.Cname +" Logic" ho
            Console.WriteLine("Modified Customer Name:: " + a.Cname);

            Console.WriteLine("Customer current Balance:: " + a.Balance);//a.Balance is read and writable
            a.Balance -= 4600;//this modification is applied only if the status is true and only if the balance remaining is 500
            Console.WriteLine("Customer later Balance:: " + a.Balance);

            Console.WriteLine("Current City of Customer :: " + a.City);
            a.City = Cities.Banepa;
            Console.WriteLine("Modified City of Customer:: " + a.City);

            Console.WriteLine("Current State of Customer :: " + a.State);
            //a.State = "Janakpur";
            Console.WriteLine("Modified State of Customer :: " + a.State);

            Console.WriteLine("Current Country of Customer :: " + a.Country);


            Console.ReadLine();
        }
    }
}
///variables of a class shouldnt be declared public
//prefixing a variable "_Variablename" means that we are gonna define its property