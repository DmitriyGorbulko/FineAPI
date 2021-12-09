using FineAPI.Entities;
using FineAPI.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services
{
    public class TypeFineService : ITypeFineService
    {
        private readonly ITypeFineRepository _typeFineRepository;
        public Task<TypeFine> Create(TypeFine typeFine)
        {
            return await _typeFineRepository.GetAsync(id);
        }

        public Task DeleteTypeFine(int id)
        {
            return await _typeFineRepository.GetAsync(id);
        }

        public Task<List<TypeFine>> GetAll()
        {
            return await _typeFineRepository.GetAsync(id);
        }

        public Task<TypeFine> GetTypeFineById(int id)
        {
            return await _typeFineRepository.GetAsync(id);
        }

        public Task UpdateTypeFine(TypeFine typeFine)
        {
            return await _typeFineRepository.GetAsync(id);
        }
    }
}
