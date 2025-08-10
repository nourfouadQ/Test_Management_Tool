using System;

namespace TestManagementAPI.Models
{
    public class TestCase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Objective { get; set; }
        public string Steps { get; set; }
        public string PreCondition { get; set; }
        public string ExpectedResult { get; set; }
        public string Status { get; set; }

        public int ScenarioId { get; set; }
        public TestScenario? Scenario { get; set; }

        public ICollection<Execution> Executions { get; set; }
    }
}
