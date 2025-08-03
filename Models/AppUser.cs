namespace AuthApi.Models;
using Microsoft.AspNetCore.Identity;

    public class AppUser : IdentityUser
    {
        public string? FullName {  get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
