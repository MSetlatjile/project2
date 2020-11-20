using System;
using System.Collections.Generic;

namespace project2.Models
{
    public partial class Education
    {
        [key]
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public int Education1 { get; set; }
        public string EducationField { get; set; }
    }
}
