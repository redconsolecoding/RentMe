using Domain.Common;

namespace Application.Exceptions
{
    public class RentMeException : Exception
    {
        public Error ErrorDetails { get; }

        public RentMeException(int code, string message, string details)
        {
            ErrorDetails = new Error(code, message, details);
        }
    }
}
