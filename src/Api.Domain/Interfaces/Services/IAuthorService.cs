using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Author;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IAuthorService
    {
        Task<AuthorResultDto> Get(Guid id);
        Task<List<AuthorResultDto>> GetAll();
        Task<AuthorEntity> Post(AuthorInsertDto author);
        Task<AuthorEntity> Put(AuthorUpdateDto author);
        Task<bool> Delete(Guid id);
    }
}