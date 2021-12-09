using FineAPI.Entities;
using FineAPI.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services
{
    public class FineService : IFineService
    {
        private readonly IFineRepository _fineRepository;
        public async Task<Fine> Create(Fine fine)
        {
            return await _fineRepository.GetAsync(fine);
        }

        public async Task DeleteFine(int id)
        {
            return await _fineRepository.GetAsync(id);
        }

        public async Task<List<Fine>> GetAll()
        {
            await _fineRepository.GetAsync();
        }

        public async Task<Fine> GetFineById(int id)
        {
            return await _fineRepository.GetAsync(id);
        }

        public async Task UpdateFine(Fine fine)
        {
            await _fineRepository.GetAsync(fine);
        }
    }
}
