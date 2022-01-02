using FineAPI.Entities;
using FineAPI.Repositories.Abstract;
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

        public FineService(IFineRepository fineRepository)
        {
            _fineRepository = fineRepository;
        }

        public async Task<Fine> CreateFine(Fine fine)
        {

            /*Account account = new Account();
            account = account.GetById(fine.PersonId);
            EmailSendService.Send(account.Email, account.FirstName, account.LastName, fine.TypeFine, fine.SumaryFine); */
            EmailSendService Sms = new EmailSendService();
            await Sms.Send("gorbulko_dmitriy@mail.ru", "Dmitriy", "Gorbulko", "{fine.TypeFine}", fine.SumaryFine);
            return await _fineRepository.Create(fine);
        }

        public Task DeleteFine(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Fine>> GetFines()
        {
            return await _fineRepository.GetAll();
        }

        public async Task<Fine> GetFineById(int id)
        {
            return await _fineRepository.GetAsync(id);
        }

        public async Task<Fine> UpdateFine(Fine fine)
        {
            return await _fineRepository.UpdateAsync(fine);
        }
    }
}
