using FirstC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_
{
    
    class Customer
    {
       
       public static void Main(string[] args)
        {



            Predicate<int> predicateDelegate = Check;
            Console.WriteLine(predicateDelegate(22));
            Console.WriteLine("Anonymous:");
            Predicate<string> predicateString = (name) => { return name.Length > 2; };
            Console.WriteLine(predicateString("Hari"));
            Console.WriteLine(predicateString("dd"));
            //If want to send more than one parameter and return bool we have to use Func Delegate


        }

        public static bool Check(int n)
        {
            return n > 0;
        }
    
    }
}