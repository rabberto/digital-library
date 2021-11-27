using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Enum;

namespace Api.Domain.Entities
{
    public class BookEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public AuthorEntity Author { get; set; }

        [Required]
        public StatusEnum Status { get; set; }
    }
}