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
        public static void Main(string[] args)
        {
            int x = 10;
            bool result = x.CheckNumber(100);
            Console.WriteLine(result);

            Person p = new Person();
            Console.WriteLine(p.CheckPerson(20));
        }
    }

    sealed class Person
    {

    }

    public static class ExtensionMethod
    {
        public static bool CheckNumber(this int i, int x)
        {
            return i > x;
        }
    }

    static class SealedAllowExtension
    {
        public static bool CheckPerson(this Person person, int age) => age > 18;
    }


}