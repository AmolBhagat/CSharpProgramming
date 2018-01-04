using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a base class print method");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a derived class print method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();
            Console.ReadKey();
        }
    }
}
