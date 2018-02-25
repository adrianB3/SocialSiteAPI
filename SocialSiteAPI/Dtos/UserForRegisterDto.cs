
using System.ComponentModel.DataAnnotations;

namespace SocialSiteAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password between 4 and 8 charcters required.")]
        public string Password { get; set; }

    }
}
