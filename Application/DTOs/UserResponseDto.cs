namespace Application.DTOs
{
    public class UserResponseDto
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public long ExpiresIn { get; set; }
        public string? TokenType { get; set; }
    }
}
