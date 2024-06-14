using FirstC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace FirstC_
{

    class Customer:IComparable<Customer>
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public int Salary { get; set; }

        public static void Main(String[] args)
        {

            List<Customer> customers = new List<Customer>();    
            customers.Add(new Customer() { Name="hari",Address="123",Salary=1500000});
            customers.Add(new Customer() { Name = "Joe", Address = "456", Salary = 25000 });
            customers.Add(new Customer() { Name = "Meghna", Address = "789", Salary = 30000 });


            customers.Sort();
            customers.ForEach((customer) => { Console.WriteLine($"{customer.Name}-{customer.Address}-{customer.Salary}"); });
        }

        public int CompareTo(Customer other)
        {
            if (this.Salary > other.Salary) return 1;
            else if (this.Salary < other.Salary) return -1;
            else return 0;
        }
    }
}