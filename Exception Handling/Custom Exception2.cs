using System;
using System.Runtime.Serialization;
namespace ExceptionHandling
{
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
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User Already logged in");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
