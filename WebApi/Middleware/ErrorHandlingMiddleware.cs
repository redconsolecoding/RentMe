using Application.DTOs.Error;
using Application.Exceptions;

namespace WebApi.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(
            RequestDelegate next,
            ILogger<ErrorHandlingMiddleware> logger
        )
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                if (exception is RentMeException rentMeException)
                {
                    context.Response.StatusCode = rentMeException.ErrorDetails.Code;
                    await context.Response.WriteAsJsonAsync(rentMeException.ErrorDetails);
                }
                else
                {
                    _logger.LogError("An unhandled exception occcured @{exception}", exception);

                    var errorDetails = new ErrorDto(
                        StatusCodes.Status500InternalServerError,
                        "Server Error",
                        ""
                    );
                    context.Response.StatusCode = errorDetails.Code;
                    await context.Response.WriteAsJsonAsync(errorDetails);
                }
            }
        }
    }
}
