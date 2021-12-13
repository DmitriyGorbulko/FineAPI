using FineAPI.Entities;
using FineAPI.Repositories.Abstract;
using FineAPI.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services
{
    public class TypeFineService : ITypeFineService
    {
        private readonly ITypeFineRepository _typeTypeFineRepository;
        public async Task<TypeFine> CreateTypeFine(TypeFine typeFine)
        {
            return await _typeTypeFineRepository.Create(typeFine);
        }

        public async Task DeleteTypeFine(int id)
        {
            await _typeTypeFineRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TypeFine>> GetTypeFines()
        {
            return await _typeTypeFineRepository.GetAll();
        }

        public async Task<TypeFine> GetTypeFineById(int id)
        {
            return await _typeTypeFineRepository.GetAsync(id);
        }

        public async Task<TypeFine> UpdateTypeFine(TypeFine typeFine)
        {
            return await _typeTypeFineRepository.UpdateAsync(typeFine);
        }
    }
}
