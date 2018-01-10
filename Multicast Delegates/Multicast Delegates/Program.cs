using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    public delegate void SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //First Approach
            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree);
            //del4 = del1 + del2 - del3;
            //del4();

            //Second Approach
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del -= SampleMethodThree;
       
            del();
            Console.ReadKey();
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }

    }
}
