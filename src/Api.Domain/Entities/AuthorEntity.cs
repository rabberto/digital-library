using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class AuthorEntity : BaseEntity
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Maximum name lenght is {1} characters")]
        public string Name { get; set; }
        public List<BookEntity> Books { get; set; }
    }
}