using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Deligate;

namespace FirstC_
{
    
    internal class Test
    {
        static void Main(String[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if(num == 0)
                    {
                        throw new Exception("num cannot be zero");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("User exception", ex);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Inner Exception :{ex.InnerException.Message}");
                Console.WriteLine(ex.Message);
            }

        }

    }
}
