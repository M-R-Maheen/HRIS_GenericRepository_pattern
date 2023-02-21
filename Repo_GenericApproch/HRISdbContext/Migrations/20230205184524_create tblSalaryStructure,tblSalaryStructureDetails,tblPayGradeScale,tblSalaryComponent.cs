using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRISDatabaseContext.Migrations
{
    /// <inheritdoc />
    public partial class createtblSalaryStructuretblSalaryStructureDetailstblPayGradeScaletblSalaryComponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblPayGradeScale",
                columns: table => new
                {
                    PayGradeScaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    ScId = table.Column<int>(type: "int", nullable: false),
                    ScAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPayGradeScale", x => x.PayGradeScaleId);
                });

            migrationBuilder.CreateTable(
                name: "tblSalaryComponent",
                columns: table => new
                {
                    ScId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsBonus = table.Column<int>(type: "int", nullable: true),
                    BonusEligibility = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalaryComponent", x => x.ScId);
                });

            migrationBuilder.CreateTable(
                name: "tblSalaryStructure",
                columns: table => new
                {
                    EssId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    GrossPay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetTaxPayable = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EscApprobedBy = table.Column<int>(type: "int", nullable: true),
                    EscApproveDate = table.Column<DateTime>(type: "date", nullable: true),
                    EscEffectiveDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalaryStructure", x => x.EssId);
                });

            migrationBuilder.CreateTable(
                name: "tblSalaryStructureDetails",
                columns: table => new
                {
                    EscDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EssId = table.Column<int>(type: "int", nullable: false),
                    ScId = table.Column<int>(type: "int", nullable: false),
                    ScValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalaryStructureDetails", x => x.EscDetailsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPayGradeScale");

            migrationBuilder.DropTable(
                name: "tblSalaryComponent");

            migrationBuilder.DropTable(
                name: "tblSalaryStructure");

            migrationBuilder.DropTable(
                name: "tblSalaryStructureDetails");
        }
    }
}
