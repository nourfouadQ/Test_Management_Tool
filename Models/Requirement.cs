namespace TestManagementAPI.Models
{
    public class Requirement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Version { get; set; }

        public int CreatedBy { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
