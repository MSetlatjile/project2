using System;
using System.Collections.Generic;

namespace project2.Models
{
    public partial class Employee
    {
        [key]
        public int EmployeeNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Over18 { get; set; }
        public string MaritalStatus { get; set; }
        public int EmployeeCount { get; set; }
        public string Attrition { get; set; }
        public int WorkLifeBalance { get; set; }
        public int RelationshipSatisfaction { get; set; }
        public int PerformanceRating { get; set; }
        public int DistanceFromHome { get; set; }
        public string BusinessTravel { get; set; }
    }
}
