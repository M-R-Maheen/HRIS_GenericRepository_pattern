using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRISDatabaseContext.Migrations
{
    /// <inheritdoc />
    public partial class Salary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblBonusPayment",
                columns: table => new
                {
                    BonusPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ScId = table.Column<int>(type: "int", nullable: false),
                    ScAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetPayout = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMonthDate = table.Column<DateTime>(type: "date", nullable: true),
                    GenerateBy = table.Column<int>(type: "int", nullable: true),
                    GenerateDate = table.Column<DateTime>(type: "date", nullable: true),
                    ApproveBy = table.Column<int>(type: "int", nullable: true),
                    ApproveDate = table.Column<DateTime>(type: "date", nullable: true),
                    PaymentBy = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    DesignationId = table.Column<int>(type: "int", nullable: true),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: true),
                    BankAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CutOffDate = table.Column<DateTime>(type: "date", nullable: true),
                    PaymentConfirmationDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBonusPayment", x => x.BonusPaymentId);
                });

            migrationBuilder.CreateTable(
                name: "tblCommonDivision",
                columns: table => new
                {
                    CDivisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCommonDivision", x => x.CDivisionId);
                });

            migrationBuilder.CreateTable(
                name: "tblCompany",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyAlias = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyRegisterNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompany", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployeeTaxInfo",
                columns: table => new
                {
                    EmployeeTaxInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    CreateBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployeeTaxInfo", x => x.EmployeeTaxInfoId);
                });

            migrationBuilder.CreateTable(
                name: "tblLoanInformation",
                columns: table => new
                {
                    LoanInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstalmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DueAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoanStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApproveBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    ApproveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Recomendation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RejectedBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    RejectDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DownpaymentAmount = table.Column<int>(type: "int", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLoanInformation", x => x.LoanInformationId);
                });

            migrationBuilder.CreateTable(
                name: "tblLoanType",
                columns: table => new
                {
                    LoanTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaximumLoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TermsAndCondition = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoanPurposeIsText = table.Column<bool>(type: "bit", nullable: true),
                    JobLength = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    CreateBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLoanType", x => x.LoanTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tblSalaryDetail",
                columns: table => new
                {
                    SalaryDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaryId = table.Column<int>(type: "int", nullable: false),
                    ScId = table.Column<int>(type: "int", nullable: false),
                    ScAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ScType = table.Column<int>(type: "int", nullable: true),
                    SalaryMonthDate = table.Column<DateTime>(type: "date", nullable: true),
                    LoanScheduleId = table.Column<int>(type: "int", nullable: true),
                    Arear = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalaryDetail", x => x.SalaryDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "tblCommonDistrict",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CDivisionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCommonDistrict", x => x.DistrictId);
                    table.ForeignKey(
                        name: "FK_tblCommonDistrict_tblCommonDivision_CDivisionId",
                        column: x => x.CDivisionId,
                        principalTable: "tblCommonDivision",
                        principalColumn: "CDivisionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblDivision",
                columns: table => new
                {
                    DivisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DivisionCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDivision", x => x.DivisionId);
                    table.ForeignKey(
                        name: "FK_tblDivision_tblCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tblCompany",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblGrade",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGrade", x => x.GradeId);
                    table.ForeignKey(
                        name: "FK_tblGrade_tblCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tblCompany",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblLoanSchedule",
                columns: table => new
                {
                    LoanScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanInformationId = table.Column<int>(type: "int", nullable: false),
                    EmiDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmiAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPaid = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLoanSchedule", x => x.LoanScheduleId);
                    table.ForeignKey(
                        name: "FK_tblLoanSchedule_tblLoanInformation_LoanInformationId",
                        column: x => x.LoanInformationId,
                        principalTable: "tblLoanInformation",
                        principalColumn: "LoanInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSalary",
                columns: table => new
                {
                    SalaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SalaryMonthDate = table.Column<DateTime>(type: "date", nullable: true),
                    EscId = table.Column<int>(type: "int", nullable: false),
                    GrossPay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetPayout = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    ApproverId = table.Column<int>(type: "int", nullable: true),
                    ApproveDate = table.Column<DateTime>(type: "date", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    BankAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentBy = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsBankPayment = table.Column<int>(type: "int", nullable: true),
                    BankPaymentBy = table.Column<int>(type: "int", nullable: true),
                    BankPaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsCashPayment = table.Column<int>(type: "int", nullable: true),
                    CashPaymentBy = table.Column<int>(type: "int", nullable: true),
                    CashPaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    PaymentConfirmationDate = table.Column<DateTime>(type: "date", nullable: true),
                    SalaryDetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalary", x => x.SalaryId);
                    table.ForeignKey(
                        name: "FK_tblSalary_tblSalaryDetail_SalaryDetailsId",
                        column: x => x.SalaryDetailsId,
                        principalTable: "tblSalaryDetail",
                        principalColumn: "SalaryDetailsId");
                });

            migrationBuilder.CreateTable(
                name: "tblCommonUpazila",
                columns: table => new
                {
                    CUpazilaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpazilaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CDistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCommonUpazila", x => x.CUpazilaId);
                    table.ForeignKey(
                        name: "FK_tblCommonUpazila_tblCommonDistrict_CDistrictId",
                        column: x => x.CDistrictId,
                        principalTable: "tblCommonDistrict",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblDepartment",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DepartmentCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDepartment", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_tblDepartment_tblDivision_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "tblDivision",
                        principalColumn: "DivisionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblDesignation",
                columns: table => new
                {
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DesignationCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDesignation", x => x.DesignationId);
                    table.ForeignKey(
                        name: "FK_tblDesignation_tblGrade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "tblGrade",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblLocation",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocationAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLocation", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_tblLocation_tblDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tblDepartment",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblRoster",
                columns: table => new
                {
                    RosterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RosterMonth = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    RosterIntime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RosterOuttime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoster", x => x.RosterId);
                    table.ForeignKey(
                        name: "FK_tblRoster_tblLocation_LocationId",
                        column: x => x.LocationId,
                        principalTable: "tblLocation",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCommonDistrict_CDivisionId",
                table: "tblCommonDistrict",
                column: "CDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCommonUpazila_CDistrictId",
                table: "tblCommonUpazila",
                column: "CDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDepartment_DivisionId",
                table: "tblDepartment",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDesignation_GradeId",
                table: "tblDesignation",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDivision_CompanyId",
                table: "tblDivision",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblGrade_CompanyId",
                table: "tblGrade",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblLoanSchedule_LoanInformationId",
                table: "tblLoanSchedule",
                column: "LoanInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_tblLocation_DepartmentId",
                table: "tblLocation",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoster_LocationId",
                table: "tblRoster",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSalary_SalaryDetailsId",
                table: "tblSalary",
                column: "SalaryDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblBonusPayment");

            migrationBuilder.DropTable(
                name: "tblCommonUpazila");

            migrationBuilder.DropTable(
                name: "tblDesignation");

            migrationBuilder.DropTable(
                name: "tblEmployeeTaxInfo");

            migrationBuilder.DropTable(
                name: "tblLoanSchedule");

            migrationBuilder.DropTable(
                name: "tblLoanType");

            migrationBuilder.DropTable(
                name: "tblRoster");

            migrationBuilder.DropTable(
                name: "tblSalary");

            migrationBuilder.DropTable(
                name: "tblCommonDistrict");

            migrationBuilder.DropTable(
                name: "tblGrade");

            migrationBuilder.DropTable(
                name: "tblLoanInformation");

            migrationBuilder.DropTable(
                name: "tblLocation");

            migrationBuilder.DropTable(
                name: "tblSalaryDetail");

            migrationBuilder.DropTable(
                name: "tblCommonDivision");

            migrationBuilder.DropTable(
                name: "tblDepartment");

            migrationBuilder.DropTable(
                name: "tblDivision");

            migrationBuilder.DropTable(
                name: "tblCompany");
        }
    }
}
