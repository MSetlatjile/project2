using System;
using System.Collections.Generic;

namespace project2.Models
{
    public partial class Money
    {
        public int EmployeeNumber { get; set; }
        public int HourlyRate { get; set; }
        public int DailyRate { get; set; }
        public int MonthlyRate { get; set; }
        public int MonthlyIncome { get; set; }
        public int PercentSalaryHike { get; set; }
        public int StockOptionLevel { get; set; }
    }
}
