using JobProcessorAPI.Models;

namespace JobProcessorAPI.Features.Jobs
{
    public class BackgroundJobRepository
    {
        private readonly List<BackgroundJob> _jobs = new();

        public List<BackgroundJob> GetAll()
        {
            return _jobs;
        }

        public BackgroundJob? GetById(int id)
        {
            return _jobs.FirstOrDefault(j => j.Id == id);
        }

        public void Add(BackgroundJob job)
        {
            job.Id = _jobs.Count + 1;
            _jobs.Add(job);
        }

        public void UpdateStatus(int id, string status)
        {
            var job = GetById(id);
            if (job is null) return;

            job.Status = status;
        }
        public bool Delete(int id)
        {
            var job = _jobs.FirstOrDefault(j => j.Id == id);
            if (job is null)
                return false;

            _jobs.Remove(job);
            return true;
        }
    }

}

