using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream_demo
{
    class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;
        public Employee(int Eno, string Ename, string job, double Salary, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location = Location;

        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;
            }
            set
            {
                Eno = (int)value;
                Ename = value.ToString();
                Job = value.ToString();
                Salary = (double)value;
                Dname = value.ToString();
                Location = (string)value;



               
            }
        }
    }
}
