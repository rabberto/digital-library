using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.User;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserResultDto> Get(Guid id);
        Task<IEnumerable<UserResultDto>> GetAll();
        Task<UserResultDto> Post(UserInsertDto user);
        Task<UserResultDto> Put(UserUpdateDto user);
        Task<bool> Delete(Guid id);
    }
}