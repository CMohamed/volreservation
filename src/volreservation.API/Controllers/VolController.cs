using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using volreservation.API.Domain.Models;
using volreservation.API.Domain.Services;

namespace volreservation.API
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly IVolService _volService;

        public ValuesController(IVolService volService) {
            _volService = volService;
        }

        [HttpGet]
        public async Task<IEnumerable<Vol>> GetAllAsync()
        {
            var vols = await _volService.ListAsync();
            return vols;
        }
    }
    }
}