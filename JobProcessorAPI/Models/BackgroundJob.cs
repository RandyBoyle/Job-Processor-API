namespace JobProcessorAPI.Models
{
    public class BackgroundJob
    {
        public int Id { get; set; }    
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

}
