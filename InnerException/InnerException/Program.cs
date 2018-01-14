using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int Result = FN / SN;

                    Console.WriteLine("Result = {0}", Result);

                }
                catch (Exception ex)
                {

                    string filePath = @"E:\All DOTNET Training Videos\CsharpVideos\Sample Files\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem , Please try again");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present");
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }
}
