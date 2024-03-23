using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Report
    {
        public string TeamComposition { get; set; }
        public string BurndownChart { get; set; }

        public Dictionary<string, int> EffortPointsPerDeveloper { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogoPath { get; set; }
        public string ProjectName { get; set; }
        public string ProjectVersion { get; set; }
        public DateTime ReportDate { get; set; }
        public Report()
        {
            EffortPointsPerDeveloper = new Dictionary<string, int>();
            ReportDate = DateTime.Now; // Standaard de huidige datum, kan worden aangepast
        }
    }
}
