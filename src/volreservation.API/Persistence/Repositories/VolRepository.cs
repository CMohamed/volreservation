using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using volreservation.API.Domain.Models;
using volreservation.API.Domain.Repositories;
using volreservation.API.Persistence.Contexts;

namespace volreservation.API.Persistence.Repositories
{
    public class VolRepository : BaseRepository, IVolRepository
    {
        public VolRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Vol>> ListAsync()
        {
            return await _context.Vols.ToListAsync();
        }
    }
}