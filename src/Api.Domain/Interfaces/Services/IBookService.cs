using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Book;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IBookService
    {
        Task<BookResultDto> Get(Guid id);
        Task<List<BookResultDto>> GetAll();
        Task<AuthorEntity> Post(BookInsertDto book);
        Task<BookEntity> Put(BookUpdateDto book);
        Task<bool> Delete(Guid id);
    }
}