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

        public Customer()
        {
            
        }

        public void TestMehtod()
        {

        }
    }
}

class ReflectionTest
{
    public static void Main(String[] args)
    {
        Type T = Type.GetType("FirstC_.Customer");

        Console.WriteLine(T.Name);
        Console.WriteLine(T.FullName);

        PropertyInfo[] property = T.GetProperties();

        foreach(PropertyInfo prop in property)
        {
            Console.WriteLine($"{prop.Name}-{prop.PropertyType.Name}");
        }

        MethodInfo[] method = T.GetMethods();

        foreach(MethodInfo met in method)
        {
            Console.WriteLine($"{met.Name}-{met.ReturnType.Name}");
        }

        ConstructorInfo[] cont = T.GetConstructors();

        foreach(ConstructorInfo ctor in cont)
        {
            Console.WriteLine($"{ctor.ToString()}");
        }
    }
}