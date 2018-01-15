using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Abuse_Solved
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a Numerator");
                int Numerator;
                bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);
                if (IsNumeratorConversionSuccessful)
                {
                    Console.WriteLine("Please enter a Denominator");
                    int Denominator;
                    bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (IsDenominatorConversionSuccessful && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine("Result ={0}", Result);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator should not be Zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be valid number between {0} & {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numerator should be valid number between {0} & {1}", Int32.MinValue, Int32.MaxValue);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
