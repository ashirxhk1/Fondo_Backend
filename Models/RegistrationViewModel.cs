using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class RegistrationViewModel
    {
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "User name is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

    }
}
