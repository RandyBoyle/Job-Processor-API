using JobProcessorAPI.Models;

namespace JobProcessorAPI.Features.Jobs
{
    public class BackgroundJobService
    {
        private readonly BackgroundJobRepository _repository;

        public BackgroundJobService(BackgroundJobRepository repository)
        {
            _repository = repository;
        }

        public List<BackgroundJob> GetAll()
        {
            return _repository.GetAll();
        }

        public BackgroundJob? GetBackgroundJobById(int id)
        {
            return _repository.GetById(id);
        }

        public void Create(BackgroundJob job)
        {
            if (string.IsNullOrWhiteSpace(job.Name))
                throw new Exception("Job name is required.");

            _repository.Add(job);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }

}
