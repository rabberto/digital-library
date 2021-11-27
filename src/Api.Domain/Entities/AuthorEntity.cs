using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class AuthorEntity : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}