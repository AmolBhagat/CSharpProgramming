using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintData()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine(Email);
        }
    }
    class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }
    class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Full Time Employee");
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Amol";
            FTE.LastName = "Bhagat";
            FTE.Email = "abc@gmail.com";
            FTE.YearlySalary = 300000;
            FTE.PrintData();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Part Time Employee");
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Csharp";
            PTE.LastName = "Programming";
            PTE.Email = "csharp@gmail.com";
            PTE.HourlyRate = 100;
            PTE.PrintData();

            Console.ReadKey();
        }
    }
}
