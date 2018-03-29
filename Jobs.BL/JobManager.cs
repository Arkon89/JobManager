using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.BL
{
    public interface IJobManager
    {
        IEnumerable<Job> GetJobList(Job.JStats askStats);
        bool AddNewJob(string jName, int jStatus);
        void DeleteNewJob(string jItem);        
        void RemoveFromTo(Job.JStats remFrom, string fromItem, Job.JStats remTo);
    }

        public class JobManager: IJobManager
    {
        List<Job> AllJobs = new List<Job> { new Job { Id = 1000, JobName = "тестовая запись", JobStatus =Job.JStats.newJob } };
        

        public IEnumerable<Job> GetJobList(Job.JStats askStats)
        {
            List<Job> _ret;
            _ret = AllJobs.Where(x => x.JobStatus == askStats).ToList<Job>();
            return _ret;
        }

        public bool AddNewJob(string jName, int jStatus)
        {
            AllJobs.Add(new Job { Id = AllJobs.Count < 1 ? 1000 : AllJobs.Max(x => x.Id) + 1, JobName = jName, JobStatus = (Job.JStats)jStatus });
            return true;
        }

        public void DeleteNewJob(string jItem)
        {
            AllJobs = AllJobs.Where(x => x.JobName != jItem && x.JobStatus == Job.JStats.newJob).ToList<Job>();
            AllJobs.OrderBy(x => x.Id);
        }

        

        public void RemoveFromTo(Job.JStats remFrom, string fromItem, Job.JStats remTo)
        {
            AllJobs.Where(x => x.JobStatus == remFrom && x.JobName == fromItem).Single().JobStatus = remTo;            
        }
    }
}
