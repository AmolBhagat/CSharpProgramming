using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                throw new UserAlreadyLoggedInException("User Already logged in - no duplicate session is allowed");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException(string message)
            : base(message)
        {
        }


        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
