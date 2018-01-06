using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int Product = 0;
            Add(10, 20);
            Add(5, 10,out Product);
            Add(10, 20, 30);
            Console.ReadKey();
        }

        public static void Add(int FN,int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, int SN, out int product)
        {
            Console.WriteLine("Sum = {0}", FN * SN);
            product = FN * SN;

        }
        public static void Add(int FN, int SN,int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }
    }
}
