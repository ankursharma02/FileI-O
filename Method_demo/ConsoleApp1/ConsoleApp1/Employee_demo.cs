using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee_demo
    {
        int Emp_Id;
        string EName;
        string EAddess;
        int Age;
        public int PEmpId
        {
            set { Emp_Id = value; }
            get { return Emp_Id; }
        }
        public string pEName
        {
            set { EName = value; }
            get { return EName; }
        }
        public string PEAddress
        {
            set { EAddess = value; }
            get { return EAddess; }
        }
        public int PAge
        {
            set { Age = value; }
            get { return Age; }
        }
    }
}
