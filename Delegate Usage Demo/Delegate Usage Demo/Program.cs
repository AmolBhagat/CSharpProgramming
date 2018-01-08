using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Usage_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Id = 101, Name = "Mark", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee { Id = 102, Name = "Mary", Salary = 6000, Experience = 4 });
            emplist.Add(new Employee { Id = 103, Name = "John", Salary = 4000, Experience = 6 });
            emplist.Add(new Employee { Id = 104, Name = "Todd", Salary = 7000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(emplist, isPromotable);

            //Employee.PromoteEmployee(emplist, emp=>emp.Experience >= 5);  //using lamda experience

            Console.ReadKey();
        }
        public static bool Promote(Employee emp)
        {
            if(emp.Experience>=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeelist,IsPromotable IsEligibleToPromote)
        {
            foreach(Employee employee in employeelist)
            {
                if(IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}
