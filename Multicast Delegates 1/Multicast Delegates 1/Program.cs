using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates_1
{
    public delegate void SampleDelegate(out int Integer);
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            int DelegateOutputParameterValue = -1;
            del(out DelegateOutputParameterValue);
            Console.WriteLine("DelegateOutputParameterValue = {0}", DelegateOutputParameterValue);
            Console.ReadKey();
        }
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
       
    }
}
