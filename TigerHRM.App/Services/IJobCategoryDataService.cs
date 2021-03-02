using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigerHRM.Shared;

namespace TigerHRM.App.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
