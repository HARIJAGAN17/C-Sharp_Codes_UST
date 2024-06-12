using FirstC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_
{
    
    class Customer<T>
    {
       
        public String Name { get; set; }    
        public int age { get; set; }

        public Customer(String Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }

        public void printing(T first,T second)
        {
            Console.WriteLine(first + ", " + second);
        }
    }
}

class TestObj
{
    public static void Main(String[] args)
    {
        Customer<string> cc = new Customer<string>("Hari",22);
        cc.printing("hari", "jagan");
    }
}