using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiger.Api.Models
{
    public interface IJobCategoryRepository
    {
        public IEnumerable<JobCategory> GetAllJobCategories();
        public JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
