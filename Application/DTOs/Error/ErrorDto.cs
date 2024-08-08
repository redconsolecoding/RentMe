namespace Application.DTOs.Error
{
    public class ErrorDto
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

        public ErrorDto(int code, string message, string details)
        {
            Code = code;
            Message = message;
            Details = details;
        }
    }
}
