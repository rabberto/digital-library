using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.User
{
    public class UserInsertDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Maximum name lenght is {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(100, ErrorMessage = "Maximum email lenght is {1} characters")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(20, ErrorMessage = "Maximum email lenght is {1} characters")]
        [MinLength(8, ErrorMessage = "Minimum email lenght is {1} characters")]
        public string Password { get; set; }
    }
}