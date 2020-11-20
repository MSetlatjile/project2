using Microsoft.EntityFrameworkCore.Migrations;

namespace project2.Migrations
{
    public partial class InnitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(nullable: false),
                    Education = table.Column<int>(nullable: false),
                    EducationField = table.Column<string>(maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(maxLength: 6, nullable: false),
                    Over18 = table.Column<string>(maxLength: 1, nullable: false),
                    MaritalStatus = table.Column<string>(maxLength: 8, nullable: false),
                    EmployeeCount = table.Column<int>(nullable: false),
                    Attrition = table.Column<string>(maxLength: 3, nullable: false),
                    WorkLifeBalance = table.Column<int>(nullable: false),
                    RelationshipSatisfaction = table.Column<int>(nullable: false),
                    PerformanceRating = table.Column<int>(nullable: false),
                    DistanceFromHome = table.Column<int>(nullable: false),
                    BusinessTravel = table.Column<string>(maxLength: 17, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mployee", x => x.EmployeeNumber);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(nullable: false),
                    NumCompaniesWorked = table.Column<int>(nullable: false),
                    TotalWorkingYears = table.Column<int>(nullable: false),
                    TrainingTimesLastYear = table.Column<int>(nullable: false),
                    YearsAtCompany = table.Column<int>(nullable: false),
                    YearsInCurrentRole = table.Column<int>(nullable: false),
                    YearsSinceLastPromotion = table.Column<int>(nullable: false),
                    YearsWithCurrManager = table.Column<int>(nullable: false),
                    EnvironmentSatisfaction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(nullable: false),
                    JobRole = table.Column<string>(maxLength: 25, nullable: false),
                    JobSatisfaction = table.Column<int>(nullable: false),
                    JobInvolvement = table.Column<int>(nullable: false),
                    JobLevel = table.Column<int>(nullable: false),
                    OverTime = table.Column<string>(maxLength: 3, nullable: false),
                    StandardHours = table.Column<int>(nullable: false),
                    Department = table.Column<string>(maxLength: 22, nullable: false),
                    BusinessTravel = table.Column<string>(maxLength: 17, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Money",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(nullable: false),
                    HourlyRate = table.Column<int>(nullable: false),
                    DailyRate = table.Column<int>(nullable: false),
                    MonthlyRate = table.Column<int>(nullable: false),
                    MonthlyIncome = table.Column<int>(nullable: false),
                    PercentSalaryHike = table.Column<int>(nullable: false),
                    StockOptionLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Money");
        }
    }
}
