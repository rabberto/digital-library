using System;
using System.Threading.Tasks;

namespace Api.Domain.Repository
{
    public interface IBookRepository
    {
        Task<bool> Reserv(Guid id);
        Task<bool> Return(Guid id);
    }
}