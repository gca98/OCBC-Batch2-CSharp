using System.ComponentModel.DataAnnotations;

namespace TodoAppRefreshToken.Models.DTO.Request
{
    public class TokenRequest
    {
        [Required]
        public string Token { get; set; }

        [Required]
        public string RefreshToken { get; set; }
    }
}