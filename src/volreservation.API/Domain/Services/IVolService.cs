using System.Collections.Generic;
using System.Threading.Tasks;
using volreservation.API.Domain.Models;

namespace volreservation.API.Domain.Services
{
    public interface IVolService
    {
         Task<IEnumerable<Vol>> ListAsync();
    }
}