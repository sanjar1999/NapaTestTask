using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs
{
    public sealed class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}
