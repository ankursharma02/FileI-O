using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrlist_demo
{
    class Customer
    {
        public int CustId{ get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    class TestCustomer
    {
        public static void Main()
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer { CustId = 101,Name="ankur", City="jaipur",Balance=123.00 };
            Customer c2 = new Customer { CustId = 102, Name = "sharma", City = "ban", Balance = 1244.00 };
            Customer c3 = new Customer { CustId = 103, Name = "abc", City = "del", Balance = 12223.00 };
            Customer c4 = new Customer { CustId = 104, Name = "xyz", City = "na", Balance = 122213.00 };
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            foreach (Customer obj in customers)
                Console.WriteLine(obj.CustId+"  "+obj.Name+" "+obj.City+" "+obj.Balance );

            Console.ReadLine();


        }
    }
}
