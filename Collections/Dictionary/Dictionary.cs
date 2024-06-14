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
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "Jaguar");
            dictionary.Add(2, "BMW");
            dictionary.Add(3, "Benz");


            foreach(var dd in dictionary){

                Console.WriteLine($"{dd.Key}-{dd.Value}");
            }

            //foreach(KeyValuePair<int,string> dd in dictionary) // above and this foreach works similar
            //{
            //    Console.WriteLine($"{dd.Key}-{dd.Value}");
            //}

            if(dictionary.TryGetValue(4,out String result)){//Gives result without any error in console

                Console.WriteLine(result);
            }
        }
    }
}