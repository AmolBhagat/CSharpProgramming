using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Abuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter Denominator");              
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int Result = Numerator / Denominator;

                Console.WriteLine("Result = {0}", Result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only numbers between {0} & {1} are allowed",
                    Int32.MinValue, Int32.MaxValue);


            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
