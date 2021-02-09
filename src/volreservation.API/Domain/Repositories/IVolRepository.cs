using System.Collections.Generic;
using System.Threading.Tasks;
using volreservation.API.Domain.Models;

namespace volreservation.API.Domain.Repositories
{
    public interface IVolRepository
    {
         Task<IEnumerable<Vol>> ListAsync();
    }
}