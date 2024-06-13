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

            

            Func<int, int, int> addDelegate = Add;
            addDelegate(1,2);

            Func<int, int, int> addAnonymus = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            };
            addAnonymus(1, 2);

            Func<int, int, int> anonymus = (num1, num2) => { return num1 + num2; };
            int result = anonymus(1, 2);
            Console.WriteLine(result);

        }
      public static int Add(int num,int num2)
        {
            return num + num2;
        }
    }
}