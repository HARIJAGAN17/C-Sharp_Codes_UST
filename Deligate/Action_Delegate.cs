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



            Action actionDelegate = () => Console.WriteLine("Without parameters");
            actionDelegate();
            Action<int> actionWithParameter = Printing;
            actionWithParameter(2);

        }

        public static void Printing(int n)
        {
            Console.WriteLine($"With parameter:{2}");
        }
    
    }
}