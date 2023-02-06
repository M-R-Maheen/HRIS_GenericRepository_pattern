using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRISDatabaseContext.Migrations
{
    /// <inheritdoc />
    public partial class AttendancesMumu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAttendenceMonthEnd",
                columns: table => new
                {
                    AttendanceMonthEndId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    RosterId = table.Column<int>(type: "int", nullable: false),
                    AttendanceMonth = table.Column<DateTime>(type: "date", nullable: true),
                    DaysOfMonth = table.Column<int>(type: "int", nullable: true),
                    AbsentDays = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LeaveDays = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Holiday = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LateDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FinalDeductionDays = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AcumulatedDays = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAttendenceMonthEnd", x => x.AttendanceMonthEndId);
                });

            migrationBuilder.CreateTable(
                name: "tblDailyAttendence",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    RosterId = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "date", nullable: false),
                    LoginTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoutTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsHoliDay = table.Column<int>(type: "int", nullable: true),
                    RosterIntime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RosterOutTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraceIn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GraceOut = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDailyAttendence", x => x.AttendanceId);
                });

            migrationBuilder.CreateTable(
                name: "tblLeaveApply",
                columns: table => new
                {
                    EmployeeLeaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: true),
                    LeaveApplyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveApprovedBy = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLeaveApply", x => x.EmployeeLeaveId);
                });

            migrationBuilder.CreateTable(
                name: "tblLeaveBalance",
                columns: table => new
                {
                    LeaveBalanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    OpeningLeaveBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SpendedLeave = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ClosingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLeaveBalance", x => x.LeaveBalanceId);
                });

            migrationBuilder.CreateTable(
                name: "tblLeaveType",
                columns: table => new
                {
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLeaveType", x => x.LeaveTypeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAttendenceMonthEnd");

            migrationBuilder.DropTable(
                name: "tblDailyAttendence");

            migrationBuilder.DropTable(
                name: "tblLeaveApply");

            migrationBuilder.DropTable(
                name: "tblLeaveBalance");

            migrationBuilder.DropTable(
                name: "tblLeaveType");
        }
    }
}
