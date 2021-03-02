using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiger.Api.Models;


namespace Tiger.Api.Controllers
{
    [Route("api/jobcategory")]
    [ApiController]
    public class JobCategoryController : ControllerBase
    {
        private readonly IJobCategoryRepository _jobCategoryRepository;

        public JobCategoryController(IJobCategoryRepository jobCategoryRepository)
        {
            _jobCategoryRepository = jobCategoryRepository;
        }
       
        [HttpGet]
        public IActionResult GetJobCategories()
        {
            return Ok(_jobCategoryRepository.GetAllJobCategories());
        }

       
        [HttpGet("{id}")]
        public IActionResult GetJobCategoryById(int id)
        {
            return Ok(_jobCategoryRepository.GetJobCategoryById(id));
        }
    }
}
