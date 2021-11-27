using System;

namespace Api.Domain.DTOs.Author
{
    public class AuthorResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}