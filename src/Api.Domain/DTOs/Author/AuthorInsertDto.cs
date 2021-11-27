using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.Author
{
    public class AuthorInsertDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Maximum name lenght is {1} characters")]
        public string Name { get; set; }
    }
}