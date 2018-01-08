using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Classes
{
    public abstract class Customer
    {
        public abstract void Print1();  //Abstract method

        public void Print2() //non abstarct method
        {
            Console.WriteLine("Non abstract method Print2 method");
        }
    }
    class Program:Customer
    {

        static void Main(string[] args)
        {
            Program P = new Program();
            P.Print1();

            Customer C1 = new Program(); //Abstract class reference variable can point to the derived class object.
            C1.Print2();
            Console.ReadKey();
        }

        public override void Print1()
        {
            Console.WriteLine("Abstract method Print1 method");
        }
    }
}
