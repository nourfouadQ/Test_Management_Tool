namespace TestManagementAPI.Models
{
    public class Execution
    {
        public int Id { get; set; }
        public int TestCaseId { get; set; }
        public TestCase TestCase { get; set; }

        public int ExecutedBy { get; set; }
        public User User { get; set; }

        public string Status { get; set; }
        public DateTime ExecutionDate { get; set; }
    }
}
