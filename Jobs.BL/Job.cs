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
        public JStats JobStatus { get; set; }
        public enum JStats
        {
            newJob,
            actualJob,
            workJob,
            readyJob,
        }

        public static IEnumerable<Job> GetAllJobs()
        {
            return new List<Job>
            {
                new Job {Id = 1000, JobName = "сварить кашу", JobStatus = JStats.newJob },
                new Job {Id = 1001, JobName = "покурить", JobStatus = JStats.newJob  },
                new Job {Id = 1002, JobName = "выгулять бархана", JobStatus = JStats.newJob  },
                new Job {Id = 1003, JobName = "погладить кота", JobStatus = JStats.newJob  }
            };
        }
    }
}
