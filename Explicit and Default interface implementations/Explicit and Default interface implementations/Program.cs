using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_and_Default_interface_implementations
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    class Program : I1, I2
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.InterfaceMethod();
            ((I2)P).InterfaceMethod();

            Console.ReadKey();
        }

        //Default implementation
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }
        //Explicit implementation
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
    }
}
