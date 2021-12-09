using FineAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services.Abstract
{
    interface ITypeFineService
    {
        Task<TypeFine> GetTypeFineById(int id);
        Task<List<TypeFine>> GetAll();
        Task<TypeFine> Create(TypeFine typeFine);
        Task UpdateTypeFine(TypeFine typeFine);
        Task DeleteTypeFine(int id);
    }
}
