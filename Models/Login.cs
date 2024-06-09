using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Login
    {
        [Required(ErrorMessage = "User name is required")]
        [MaxLength(20,ErrorMessage ="Max characters is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "User name is required")]
        [MaxLength(20, ErrorMessage = "Max characters is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
