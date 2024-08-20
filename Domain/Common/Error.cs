using System.Collections;

namespace Domain.Common
{
    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public IDictionary Data { get; set; }

        public static readonly Error None = new(0, string.Empty, string.Empty);

        public Error(int code, string message, string details, IDictionary data)
        {
            Code = code;
            Message = message;
            Details = details;
            Data = data;
        }

        public Error(int code, string message, string details)
        {
            Code = code;
            Message = message;
            Details = details;
        }
    }
}
