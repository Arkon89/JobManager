using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.BL
{
    class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }

        public static IEnumerable<Job> GetAllJobs()
        {
            return new List<Job>
            {
                new Job {Id = 1000, JobName = "сварить кашу" }
            };
        }
    }
}
