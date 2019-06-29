using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "You must specify password betweent 5 and 25 chars")]
        public string Password { get; set; }
    }
}