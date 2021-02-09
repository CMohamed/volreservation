using System.Collections.Generic;
using System.Threading.Tasks;
using volreservation.API.Domain.Models;
using volreservation.API.Domain.Services;

namespace volreservation.API.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            this._companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Company>> ListAsync()
        { 
            return await _companyRepository.ListAsync();
        }
    }
}