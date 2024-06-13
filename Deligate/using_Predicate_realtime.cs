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

    class Customer
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public int salary { get; set; }

        public static void PromoteEmployee(Customer[] customers, Predicate<Customer> promotable)
        {
            foreach (Customer cc in customers)
            {
                if (promotable(cc))
                {
                    Console.WriteLine(cc.Name);
                }
            }
        }

    }

    class Tester
    {
        public static void Main(String[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer { Name = "raj", Id = 3, salary = 15000 };
            customers[1] = new Customer { Id = 23, Name = "Peter", salary = 19000 };
            customers[2] = new Customer { Id = 24, Name = "Duolingo", salary = 10000 };


            //Predicate<Customer> promotable = promotionCheck;
             

            Predicate<Customer> promotable = (Customer cc) =>
            {

                if (cc.salary > 10000)
                {
                    return true;
                }
                return false;
            };
            Customer.PromoteEmployee(customers, promotable);

        }

        public static bool promotionCheck(Customer cc)
        {
            if (cc.salary > 10000)
            {
                return true;
            }
            return false;
        }
    }
}