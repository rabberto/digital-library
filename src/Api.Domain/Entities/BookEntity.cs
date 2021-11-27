using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Enum;

namespace Api.Domain.Entities
{
    public class BookEntity : BaseEntity
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Maximum name lenght is {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public Guid AuthorId { get; set; }

        public AuthorEntity Author { get; set; }
    }
}