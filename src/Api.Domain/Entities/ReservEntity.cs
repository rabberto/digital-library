using System;
using Api.Domain.Enum;

namespace Api.Domain.Entities
{
    public class ReservEntity : BaseEntity
    {
        public Guid BookId { get; set; }
        public BookEntity Book { get; set; }
        public StatusEnum Status { get; set; }
    }
}