using Application.DTOs.Error;

namespace Application.Exceptions
{
    public class RentMeException : Exception
    {
        public ErrorDto ErrorDetails { get; }

        public RentMeException(int code, string message, string details)
        {
            ErrorDetails = new ErrorDto(code, message, details);
        }
    }
}
