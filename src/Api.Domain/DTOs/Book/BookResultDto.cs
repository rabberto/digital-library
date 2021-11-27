using System;
using Api.Domain.DTOs.Author;

namespace Api.Domain.DTOs.Book
{
    public class BookResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Guid AuthorId { get; set; }
        public AuthorResultDto Author { get; set; }
    }
}