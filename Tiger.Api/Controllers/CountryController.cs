using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiger.Api.Models;



namespace Tiger.Api.Controllers
{
    [Route("api/country")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        
        [HttpGet]
        public IActionResult GetCountries()
        {
            return Ok(_countryRepository.GetAllCountries());
        }

       
        [HttpGet("{id}")]
        public IActionResult GetCountryById(int id)
        {
            return Ok(_countryRepository.GetCountryById(id));
        }
    }
}
