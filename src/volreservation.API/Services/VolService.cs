using System.Collections.Generic;
using System.Threading.Tasks;
using volreservation.API.Domain.Models;
using volreservation.API.Domain.Services;

namespace volreservation.API.Services
{
    public class VolService : IVolService
    {
        public async Task<IEnumerable<Vol>> ListAsync()
        {
        }
    }
}