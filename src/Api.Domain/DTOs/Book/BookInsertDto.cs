using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.Book
{
    public class BookInsertDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Maximum name lenght is {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public Guid AuthorId { get; set; }
    }
}