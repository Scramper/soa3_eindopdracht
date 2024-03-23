
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class SprintReportGenerator
    {

        public SprintReportGenerator()
        {
        }

        public void GenerateReportForSprint(Sprint sprint)
        {
            var burndownChart = GenerateBurndownChart(sprint);
            var effortPointsPerDeveloper = CalculateEffortPointsPerDeveloper(sprint);

            var report = new Report
            {
            };

            // Exporteer het rapport naar verschillende formaten
            ExportReportToPdf(report);
            ExportReportToPng(report);
        }

        private object GenerateBurndownChart(Sprint sprint)
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, int> CalculateEffortPointsPerDeveloper(Sprint sprint)
        {
            throw new NotImplementedException();
        }

        private void ExportReportToPdf(Report report)
        {
            throw new NotImplementedException();
        }

        private void ExportReportToPng(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
