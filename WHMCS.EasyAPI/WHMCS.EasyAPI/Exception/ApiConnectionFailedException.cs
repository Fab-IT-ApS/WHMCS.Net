
namespace Whmcs.Exception
{
    public class ApiConnectionFailedException : System.Exception
    {
        public ApiConnectionFailedException()
        {
            
        }

        public ApiConnectionFailedException(string message)
            : base(message)
        {
            
        }

        public ApiConnectionFailedException(string message, System.Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
