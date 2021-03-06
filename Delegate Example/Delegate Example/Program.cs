﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example
{
    public delegate void HelloFunctionDelegate(string Message);
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");
            Console.ReadKey();
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
