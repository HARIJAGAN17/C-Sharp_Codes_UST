using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Deligate;

namespace FirstC_
{
    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }

        public static void PromotionEmployee(Employee[] employees, PromotionCheck ispromotion)
        {
            foreach(Employee employee in employees)
            {
                if (ispromotion(employee))
                {
                    Console.WriteLine($"{employee.Name} is Eligible for Promotion");
                }
            }
        }
    }
}



----------------------------------------------------------------------------------------------------------

using FirstC_;
using System;

class Deligate
{

    public delegate Boolean PromotionCheck(Employee employee);
   
    public static void Main(String[] args)
    {
        Employee[] employees = new Employee[3];
        employees[0] = new Employee() { Id = 22, Name = "John", salary = 15000 };
        employees[1] = new Employee() { Id = 23, Name = "Peter", salary = 19000 };
        employees[2] = new Employee() { Id = 24, Name = "Duolingo", salary = 10000 };


        PromotionCheck ispromotion = new PromotionCheck(Promotion);
        Employee.PromotionEmployee(employees,ispromotion);
    }

    public static Boolean Promotion(Employee employee)
    {
        if (employee.salary > 10000)
            return true;
        return false;
    }
}