using JobProcessorAPI.Models;
using Microsoft.AspNetCore.Builder;

namespace JobProcessorAPI.Features.Jobs
{
    public static class JobEndpoints
    {
        public static void MapJobEndpoints(this WebApplication app)
        {
            app.MapGet("/jobs", (BackgroundJobService service) =>
                Results.Ok(service.GetAll()));

            app.MapGet("/jobs/{id:int}",
            (int id, BackgroundJobService service) =>
            {
                var job = service.GetBackgroundJobById(id);
                return job is null
                    ? Results.NotFound()
                    : Results.Ok(job);
            });

            app.MapPost("/jobs", (BackgroundJob job, BackgroundJobService service) =>
            {
                if (string.IsNullOrWhiteSpace(job.Name))
                    return Results.BadRequest(new { error = "Job name is required." });

                service.Create(job);
                return Results.Created($"/jobs/{job.Id}", job);
            });

            app.MapDelete("/jobs/{id:int}", (int id, BackgroundJobService service) =>
            {
                var removed = service.Delete(id);
                return removed 
                    ? Results.NoContent() 
                    : Results.NotFound();
            });
        }
    }
}
