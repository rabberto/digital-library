using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.Author
{
    public class AuthorUpdateDto
    {
        [Required(ErrorMessage = "Id is required.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Maximum name lenght is {1} characters")]
        public string Name { get; set; }
    }
}