namespace TestManagementAPI.Models
{
    public class TestScenario
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Status { get; set; }
        public int Estimate { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public ICollection<TestCase> TestCases { get; set; }
    }
}
