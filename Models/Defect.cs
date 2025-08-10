namespace TestManagementAPI.Models
{
    public class Defect
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StepsToReproduce { get; set; }
        public string Severity { get; set; }
        public string Priority { get; set; }
        public string ExpectedResult { get; set; }
        public string ActualResult { get; set; }

        public int TestCaseId { get; set; }
        public TestCase TestCase { get; set; }
    }
}
