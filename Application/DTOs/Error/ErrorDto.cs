using System.Collections;

namespace Application.DTOs.Error
{
    public class ErrorDto
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public IDictionary? Data { get; set; }

        public ErrorDto(int code, string message, string details, IDictionary data)
        {
            Code = code;
            Message = message;
            Details = details;
            Data = data;
        }

        public ErrorDto(int code, string message, string details)
        {
            Code = code;
            Message = message;
            Details = details;
        }
    }
}
