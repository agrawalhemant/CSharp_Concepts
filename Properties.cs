using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public class Properties
    {
        public static void Main(string[] args)
        {
            TestProperty obj = new TestProperty(1,"Hemant",true,696969.69, TestProperty.Cities.Mathura,"UP");
            Console.WriteLine($"Customer Id : {obj.cId}");
            Console.WriteLine($"Customer Name : {obj.cName}");
            Console.WriteLine($"Customer Status : {obj.status}");
            Console.WriteLine($"Customer City : {obj.city}");
            Console.WriteLine($"Customer State : {obj.state}");
            Console.WriteLine($"Customer Country : {obj.country}");
            Console.WriteLine($"Customer Balance : {obj.balance}");
            Console.WriteLine();

            obj.status = false;
            //obj.cName = "XYZ";    //since set property for name is protected, it can only be accessed by child class
            obj.balance = obj.balance - 1000000;
            obj.city = TestProperty.Cities.Lucknow;
            obj.state = "UP"; 
            Console.WriteLine($"Modified Customer Status : {obj.status}");
            Console.WriteLine($"Nothing can be changed since status is {obj.status}");
            Console.WriteLine($"Modified Customer Name : {obj.cName}");
            Console.WriteLine($"Modified Customer City : {obj.city}");
            Console.WriteLine($"Customer State : {obj.state}");
            Console.WriteLine($"Customer Country : {obj.country}");
            Console.WriteLine($"Modified Customer Balance : {obj.balance}");
            Console.WriteLine();
            Console.BackgroundColor= ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            obj.status = true;
            //obj.cName = "PQR";    //since set property for name is protected, it can only be accessed by child class
            obj.city = TestProperty.Cities.Delhi;
            obj.state = "Delhi";
            //obj.country = "Nepal";    //since set is not defined for country property we can't change it's value
            obj.balance = obj.balance - 1000000;
            Console.WriteLine($"Modified Customer Status : {obj.status}");
            Console.WriteLine($"We can change now since status is {obj.status}");
            Console.WriteLine($"Modified Customer Name : {obj.cName}");
            Console.WriteLine($"Modified Customer City : {obj.city}");
            Console.WriteLine($"Customer State : {obj.state}");
            Console.WriteLine($"Customer Country : {obj.country}");
            Console.WriteLine($"Modified Customer Balance : {obj.balance}");
            Console.WriteLine($"Balance didn't change since minimum balance has to be 500");
            Console.WriteLine();

            obj.balance = obj.balance - 10000;
            Console.WriteLine($"Balance changed to : {obj.balance}");

        }
    }

    public class TestProperty
    {
        int _cId;
        bool _status;
        double _balance;
        string _cName;
        public enum Cities
        {
            Mathura, Delhi, Mumbai, Hyderabad, Lucknow, Chandigarh
        }

        Cities _city;
        public TestProperty(int cId,string cName, bool status, double balance, Cities city, string state)
        {
            _cId = cId;
            _status = status;
            _balance = balance;
            _cName = cName;
            _city = city;
            this.state = state;
        }

        public int cId
        {
            get { return _cId; }
        }
        public bool status
        {
            get { return _status; }
            set { _status = value; }
        }
        public double balance
        {
            get { return _balance; }
            set
            {
                if (_status == true)
                {
                    if (value >= 500)
                    {
                        _balance = value;
                    }                     
                }
            }
        }
        public string cName
        {
            get { return _cName; }
            protected set
            {
                if(_status == true)
                {
                    _cName = value;
                }
            }
        }

        public Cities city
        {
            get { return _city; }
            set
            {
                if (status == true)
                {
                    _city = value;
                }
            }
        }

        public string state //auto-implemented property
        {
            get;
            set;
        }

        public string country //auto property initializer
        {get;} = "India";

    }
}
