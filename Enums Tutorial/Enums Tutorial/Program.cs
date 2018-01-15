using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] Values = (long[])Enum.GetValues(typeof(Gender));
            foreach(int value in Values)
            {
                Console.WriteLine(value);
            }

            string[] Names = Enum.GetNames(typeof(Gender));
            foreach (string names in Names)
            {
                Console.WriteLine(names);
            }
            Console.ReadKey();
        }
    }
    public enum Gender : long
    {
        Unknown = 1,
        Male = 2,
        Female =3
    }
}
