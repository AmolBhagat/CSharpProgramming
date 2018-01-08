using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Interfaces
{
    interface ICustomer1
    {     
        void Print1();
    }
    interface ICustomer2:ICustomer1
    {
        void Print2();
    }
    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Prit1 Method");
        }

        public void Print2()
        {
            Console.WriteLine("Prit2 Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();

            ICustomer1 cust = new Customer();
            cust.Print1();
            Console.ReadKey();
        }
    }
}
