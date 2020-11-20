using System;
using System.Collections.Generic;

namespace project2.Models
{
    public partial class Job
    {
        public int EmployeeNumber { get; set; }
        public string JobRole { get; set; }
        public int JobSatisfaction { get; set; }
        public int JobInvolvement { get; set; }
        public int JobLevel { get; set; }
        public string OverTime { get; set; }
        public int StandardHours { get; set; }
        public string Department { get; set; }
        public string BusinessTravel { get; set; }
    }
}
