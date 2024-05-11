using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public class Indexers
    {
        int ENo;
        double Salary;
        string EName, DName, Location;
        
        //constructor
        public Indexers(int Eno,string Ename,string DName, double Salary, string Location)
        {
            this.ENo = Eno;
            this.EName = Ename;
            this.DName = DName;
            this.Location = Location;
            this.Salary = Salary;
        }
        public object this[int index]
        {
            get
            {
                if(index == 1)
                {
                    return ENo;
                }
                else if(index == 2)
                {
                    return EName;
                }
                else if (index ==3)
                {
                    return DName;
                }
                else if (index == 4)
                {
                    return Salary;
                }
                else if (index == 5)
                {
                    return Location;
                }
                else{
                    return null;
                }
            }
            set
            {
                if (index == 1)
                {
                    this.ENo = (int) value;
                }
                else if (index == 2)
                {
                    this.EName = (string) value ;
                }
                else if (index == 3)
                {
                    this.DName= (string)value;
                }
                else if (index == 4)
                {
                    this.Salary= (double) value;
                }
                else if (index == 5)
                {
                    this.Location= (string) value;
                }
            }
        }

        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "ENO")
                {
                    return ENo;
                }
                else if (name.ToUpper() == "ENAME")
                {
                    return EName;
                }
                else if (name.ToUpper() == "DNAME")
                {
                    return DName;
                }
                else if (name.ToUpper() == "SALARY")
                {
                    return Salary;
                }
                else if (name.ToUpper() == "LOCATION")
                {
                    return Location;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (name.ToUpper() == "ENO")
                {
                    this.ENo = (int)value;
                }
                else if (name.ToUpper() == "ENAME")
                {
                    this.EName = (string)value;
                }
                else if (name.ToUpper() == "DNAME")
                {
                    this.DName = (string)value;
                }
                else if (name.ToUpper() == "SALARY")
                {
                    this.Salary = (double)value;
                }
                else if (name.ToUpper() == "LOCATION")
                {
                    this.Location = (string)value;
                }
            }
        }
    }

    public class TextIndexers
    {
        public static void Main(string[] args)
        {
            Indexers ob = new Indexers(1,"Hemant","IT",31011.11,"Mathura");
            Console.WriteLine("ENo : " + ob[1]);
            Console.WriteLine("EName : " + ob[2]);
            Console.WriteLine("DName : " + ob[3]);
            Console.WriteLine("Salary : " + ob[4]);
            Console.WriteLine("Location : " + ob[5]);
            Console.WriteLine("");
            ob[3] = "Sales";
            ob["salary"] = 25000.01;
            Console.WriteLine("Modified DName : " + ob["dname"]);
            Console.WriteLine("Modified Salary : " + ob[4]);
        }
    }
}
