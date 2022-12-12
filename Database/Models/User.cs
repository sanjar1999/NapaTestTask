using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public sealed class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool isAdmin { get; set; } = false;
    }
}
