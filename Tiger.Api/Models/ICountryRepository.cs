using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiger.Api.Models
{
    public interface ICountryRepository
    {
        public IEnumerable<Country> GetAllCountries();
        public Country GetCountryById(int countryId);
    }
}
