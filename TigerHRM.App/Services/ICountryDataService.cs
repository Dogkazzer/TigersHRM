using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigerHRM.Shared;

namespace TigerHRM.App.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
