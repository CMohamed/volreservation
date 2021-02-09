using System.Collections.Generic;
using System.Threading.Tasks;
using volreservation.API.Domain.Models;

namespace volreservation.API.Domain.Services
{
    public interface ICompanyService
    {
         Task<IEnumerable<Company>> ListAsync();
    }
}