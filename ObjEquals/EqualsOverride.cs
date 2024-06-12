using FirstC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_
{
    
    class Customer
    {
       
        public String Name { get; set; }    
        public int age { get; set; }

        public Customer(String Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            else if (!(obj is Customer)) return false;

            return this.Name == ((Customer)obj).Name && this.age == ((Customer)obj).age;
        }
    }
}

class TestObj
{
    public static void Main(String[] args)
    {
        Customer cc = new Customer("Hari", 99);
        Customer c2 = new Customer("Hari", 99);
        Console.WriteLine(cc.Equals(c2));
    }
}