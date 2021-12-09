using FineAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services.Abstract
{
    public interface IFineService
    {
        Task<Fine> GetFineById(int id);
        Task<List<Fine>> GetAll();
        Task<Fine> Create(Fine fine);
        Task UpdateFine(Fine fine);
        Task DeleteFine(int id);
    }
}
