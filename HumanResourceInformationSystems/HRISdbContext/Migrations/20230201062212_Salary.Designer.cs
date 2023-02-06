﻿// <auto-generated />
using System;
using HRIS.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRISDatabaseContext.Migrations
{
    [DbContext(typeof(HRISdbContext))]
    [Migration("20230201062212_Salary")]
    partial class Salary
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DivisionId")
                        .HasColumnType("int");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentId");

                    b.HasIndex("DivisionId");

                    b.ToTable("tblDepartment");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignationId"));

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DesignationCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DesignationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DesignationId");

                    b.HasIndex("GradeId");

                    b.ToTable("tblDesignation");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Division", b =>
                {
                    b.Property<int>("DivisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DivisionId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DivisionName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DivisionId");

                    b.HasIndex("CompanyId");

                    b.ToTable("tblDivision");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("GradeId");

                    b.HasIndex("CompanyId");

                    b.ToTable("tblGrade");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("LocationAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LocationId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("tblLocation");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CommonTables.CDistrict", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"));

                    b.Property<int>("CDivisionId")
                        .HasColumnType("int");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DistrictId");

                    b.HasIndex("CDivisionId");

                    b.ToTable("tblCommonDistrict");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CommonTables.CDivision", b =>
                {
                    b.Property<int>("CDivisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CDivisionId"));

                    b.Property<string>("DivisionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CDivisionId");

                    b.ToTable("tblCommonDivision");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CommonTables.CUpazila", b =>
                {
                    b.Property<int>("CUpazilaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CUpazilaId"));

                    b.Property<int>("CDistrictId")
                        .HasColumnType("int");

                    b.Property<string>("UpazilaName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CUpazilaId");

                    b.HasIndex("CDistrictId");

                    b.ToTable("tblCommonUpazila");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CompanyInformation.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CompanyAlias")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyRegisterNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("tblCompany");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CompanyInformation.Roster", b =>
                {
                    b.Property<int>("RosterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RosterId"));

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("RosterIntime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RosterMonth")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("RosterOuttime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RosterId");

                    b.HasIndex("LocationId");

                    b.ToTable("tblRoster");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.EmployeeTaxInformation.EmployeeTaxInfo", b =>
                {
                    b.Property<int>("EmployeeTaxInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeTaxInfoId"));

                    b.Property<int?>("CreateBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<decimal?>("TaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UpdateBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeTaxInfoId");

                    b.ToTable("tblEmployeeTaxInfo");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.Loan.LoanInformation", b =>
                {
                    b.Property<int>("LoanInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanInformationId"));

                    b.Property<int?>("ApproveBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("ApproveDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DownpaymentAmount")
                        .HasColumnType("int");

                    b.Property<decimal?>("DueAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InstalmentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("LoanAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("LoanStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Recomendation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("RejectDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RejectedBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("TotalPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UpdateBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("LoanInformationId");

                    b.ToTable("tblLoanInformation");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.Loan.LoanSchedule", b =>
                {
                    b.Property<int>("LoanScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanScheduleId"));

                    b.Property<int?>("CreateBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("EmiAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("EmiDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IsPaid")
                        .HasColumnType("int");

                    b.Property<int>("LoanInformationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PaidDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LoanScheduleId");

                    b.HasIndex("LoanInformationId");

                    b.ToTable("tblLoanSchedule");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.Loan.LoanType", b =>
                {
                    b.Property<int>("LoanTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanTypeId"));

                    b.Property<int?>("CreateBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("JobLength")
                        .HasColumnType("int");

                    b.Property<bool?>("LoanPurposeIsText")
                        .HasColumnType("bit");

                    b.Property<string>("LoanTypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("MaximumLoanAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Status")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("TermsAndCondition")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UpdateBy")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LoanTypeId");

                    b.ToTable("tblLoanType");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.SalaryInformation.BonusPayment", b =>
                {
                    b.Property<int>("BonusPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BonusPaymentId"));

                    b.Property<string>("AccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ApproveBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ApproveDate")
                        .HasColumnType("date");

                    b.Property<string>("BankAccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BankId")
                        .HasColumnType("int");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CutOffDate")
                        .HasColumnType("date");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DesignationId")
                        .HasColumnType("int");

                    b.Property<int?>("DivisionId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("GenerateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GenerateDate")
                        .HasColumnType("date");

                    b.Property<int?>("GradeId")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("NetPayout")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PaymentBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PaymentConfirmationDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("PaymentMonthDate")
                        .HasColumnType("date");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ScAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ScId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("BonusPaymentId");

                    b.ToTable("tblBonusPayment");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.SalaryInformation.Salary", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaryId"));

                    b.Property<DateTime?>("ApproveDate")
                        .HasColumnType("date");

                    b.Property<int?>("ApproverId")
                        .HasColumnType("int");

                    b.Property<string>("BankAccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BankPaymentBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BankPaymentDate")
                        .HasColumnType("date");

                    b.Property<int?>("CashPaymentBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CashPaymentDate")
                        .HasColumnType("date");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("date");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<int>("DivisionId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<int>("EscId")
                        .HasColumnType("int");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("GrossPay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("IsBankPayment")
                        .HasColumnType("int");

                    b.Property<int?>("IsCashPayment")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("date");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("NetPayout")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PaymentBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PaymentConfirmationDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<int?>("SalaryDetailsId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SalaryMonthDate")
                        .HasColumnType("date");

                    b.Property<string>("SalaryRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.HasKey("SalaryId");

                    b.HasIndex("SalaryDetailsId");

                    b.ToTable("tblSalary");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.SalaryInformation.SalaryDetail", b =>
                {
                    b.Property<int>("SalaryDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaryDetailsId"));

                    b.Property<decimal?>("Arear")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("date");

                    b.Property<int?>("LoanScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SalaryMonthDate")
                        .HasColumnType("date");

                    b.Property<decimal?>("ScAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ScId")
                        .HasColumnType("int");

                    b.Property<int?>("ScType")
                        .HasColumnType("int");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("date");

                    b.HasKey("SalaryDetailsId");

                    b.ToTable("tblSalaryDetail");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Department", b =>
                {
                    b.HasOne("HRIS.DatabaseModels.CompanyInformation.Division", null)
                        .WithMany("Departments")
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Designation", b =>
                {
                    b.HasOne("HRIS.DatabaseModels.CompanyInformation.Grade", null)
                        .WithMany("Designations")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Division", b =>
                {
                    b.HasOne("HRISdatabaseModels.DatabaseModels.CompanyInformation.Company", null)
                        .WithMany("Divisions")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Grade", b =>
                {
                    b.HasOne("HRISdatabaseModels.DatabaseModels.CompanyInformation.Company", null)
                        .WithMany("Grades")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Location", b =>
                {
                    b.HasOne("HRIS.DatabaseModels.CompanyInformation.Department", null)
                        .WithMany("Locations")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CommonTables.CDistrict", b =>
                {
                    b.HasOne("HRISdatabaseModels.DatabaseModels.CommonTables.CDivision", null)
                        .WithMany("CDistrict")
                        .HasForeignKey("CDivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CommonTables.CUpazila", b =>
                {
                    b.HasOne("HRISdatabaseModels.DatabaseModels.CommonTables.CDistrict", null)
                        .WithMany("CUpazila")
                        .HasForeignKey("CDistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CompanyInformation.Roster", b =>
                {
                    b.HasOne("HRIS.DatabaseModels.CompanyInformation.Location", null)
                        .WithMany("Rosters")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.Loan.LoanSchedule", b =>
                {
                    b.HasOne("HRISdatabaseModels.DatabaseModels.Loan.LoanInformation", null)
                        .WithMany("LoanSchedules")
                        .HasForeignKey("LoanInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.SalaryInformation.Salary", b =>
                {
                    b.HasOne("HRISdatabaseModels.DatabaseModels.SalaryInformation.SalaryDetail", null)
                        .WithMany("Salaries")
                        .HasForeignKey("SalaryDetailsId");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Department", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Division", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Grade", b =>
                {
                    b.Navigation("Designations");
                });

            modelBuilder.Entity("HRIS.DatabaseModels.CompanyInformation.Location", b =>
                {
                    b.Navigation("Rosters");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CommonTables.CDistrict", b =>
                {
                    b.Navigation("CUpazila");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CommonTables.CDivision", b =>
                {
                    b.Navigation("CDistrict");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.CompanyInformation.Company", b =>
                {
                    b.Navigation("Divisions");

                    b.Navigation("Grades");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.Loan.LoanInformation", b =>
                {
                    b.Navigation("LoanSchedules");
                });

            modelBuilder.Entity("HRISdatabaseModels.DatabaseModels.SalaryInformation.SalaryDetail", b =>
                {
                    b.Navigation("Salaries");
                });
#pragma warning restore 612, 618
        }
    }
}
