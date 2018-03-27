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
        void AddNewJob(string jName);
        void DeleteNewJob(string jName);
    }

    class JobManager: IJobManager
    {
        List<Job> AllJobs = new List<Job>();
        List<Job> ActualJobs = new List<Job>();
        List<Job> WorkJobs = new List<Job>();
        List<Job> ReadyJobs = new List<Job>();

        public IEnumerable<Job> GetJobList(Job.JStats askStats)
        {
            switch (askStats)
            {
                case Job.JStats.newJob:
                    return AllJobs;
                    //break;
                case Job.JStats.actualJob:
                    return ActualJobs;
                    //break;
                case Job.JStats.workJob:
                    return WorkJobs;
                    //break;
                case Job.JStats.readyJob:
                    return ReadyJobs;
                    //break;

                default:
                    return new List<Job>();
                    //break;
            }
        }

        public void AddNewJob(string jName)
        {
            AllJobs.Add(new Job { Id = AllJobs.Count + 1001, JobName = jName, JobStatus = Job.JStats.newJob });
        }

        public void DeleteNewJob(string jName)
        {
            AllJobs = AllJobs.Where(x => x.JobName != jName).ToList<Job>();

        }

    }
}
