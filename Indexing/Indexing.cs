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
        public int Id { get; set; }
        public string Name { get; set; }

    }

    class Tester
    {
        List<Customer> list;

        public Tester()
        {
            list = new List<Customer>()
            {
               new Customer() { Id = 1,Name="Raj"},
               new Customer() { Id = 2,Name="Banno"},
               new Customer() { Id = 3,Name="Malo"},
            };
        }

        public string this[int x]
        {
            get
            {
                Customer cc  = list.Find((e)=> e.Id==x );
                return cc.Name;
            }
            set
            {
                Customer cc = list.Find((e) => e.Id == x);
                cc.Name = value;
            }
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Tester tt = new Tester();
            Console.WriteLine(tt[2]);
            Console.WriteLine(tt[3]);
            
        }
    }



}