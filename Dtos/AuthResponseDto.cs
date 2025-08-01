namespace AuthApi.Dtos
{
    public class AuthResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public string Token { get; set; }
    }
}
