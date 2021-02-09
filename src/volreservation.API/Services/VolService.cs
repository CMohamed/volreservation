using System.Collections.Generic;
using System.Threading.Tasks;
using volreservation.API.Domain.Models;
using volreservation.API.Domain.Services;

namespace volreservation.API.Services
{
    public class VolService : IVolService
    {
        private readonly IVolRepository _volRepository;

        public VolService(IVolRepository volRepository)
        {
            this._volRepository = volRepository;
        }

        public async Task<IEnumerable<Vol>> ListAsync()
        { 
            return await _volRepository.ListAsync();
        }
    }
}