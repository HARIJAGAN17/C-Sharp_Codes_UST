using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Deligate;

namespace FirstC_
{
    enum Gender
    {
        Male,Female,Unknown,
    }

    class Employee
    {
        public string name {  get; set; }
        public Gender gender { get; set; }
       
    }
    internal class Test
    {
        static void Main(String[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee { name = "Harry", gender = Gender.Male };
            employees[1] = new Employee { name = "madona",gender = Gender.Female };
            employees[2] = new Employee { name = "marko",gender = Gender.Unknown };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.name} , gender is {GenderCheck(employee.gender)}");
            }

        }

        static String GenderCheck(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                case Gender.Unknown:
                    return "Unknown";
                default:
                    return "Invalid input";
            }
  
        }
    }
}
