using HRIS.DatabaseModels.CompanyInformation;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using HRISdatabaseModels.DatabaseModels.CommonTables;
using HRISdatabaseModels.DatabaseModels.CompanyInformation;
using HRISdatabaseModels.DatabaseModels.EmployeeTaxInformation;
using HRISdatabaseModels.DatabaseModels.Loan;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using HRISdatabaseModels.DatabaseModels.SalaryStructure;
using Microsoft.EntityFrameworkCore;

namespace HRIS.DatabaseContext
{
    public class HRISdbContext:DbContext
    {
        public HRISdbContext(DbContextOptions<HRISdbContext> options):base(options)
        {

        }

        public DbSet<Company> tblCompany => Set<Company>();
        public DbSet<Grade> tblGrade => Set<Grade>();
        public DbSet<Designation> tblDesignation => Set<Designation>();
        public DbSet<Division> tblDivision => Set<Division>();
        public DbSet<Department> tblDepartment => Set<Department>();
        public DbSet<Location> tblLocation => Set<Location>();
        public DbSet<Roster> tblRoster => Set<Roster>();


        public DbSet<CDivision> tblCommonDivision => Set<CDivision>();
        public DbSet<CDistrict> tblCommonDistrict => Set<CDistrict>();
        public DbSet<CUpazila> tblCommonUpazila => Set<CUpazila>();

        //Table of Nur-Vai
        public DbSet<EmployeeTaxInfo> tblEmployeeTaxInfo => Set<EmployeeTaxInfo>();
        public DbSet<LoanInformation> tblLoanInformation => Set<LoanInformation>();
        public DbSet<LoanSchedule> tblLoanSchedule => Set<LoanSchedule>();
        public DbSet<LoanType> tblLoanType => Set<LoanType>();

        //Work Of Mamun
        public DbSet<Salary> tblSalary => Set<Salary>();
        public DbSet<SalaryDetail> tblSalaryDetail => Set<SalaryDetail>();
        public DbSet<BonusPayment> tblBonusPayment => Set<BonusPayment>();

        //salary Structure Rahima Akter
        public DbSet<EmployeeSalaryStructure> tblSalaryStructure => Set<EmployeeSalaryStructure>();
        public DbSet<EmployeeSalaryStructureDetails> tblSalaryStructureDetails => Set<EmployeeSalaryStructureDetails>();
        public DbSet<PayGradeScale> tblPayGradeScale => Set<PayGradeScale>();
        public DbSet<SalaryComponent> tblSalaryComponent => Set<SalaryComponent>();

        //Mumu
        public DbSet<DailyAttendence> tblDailyAttendence => Set<DailyAttendence>();
        public DbSet<LeaveType> tblLeaveType => Set<LeaveType>();
        public DbSet<LeaveApply> tblLeaveApply => Set<LeaveApply>();
        public DbSet<LeaveBalance> tblLeaveBalance => Set<LeaveBalance>();
        public DbSet<AttendenceMonthEnd> tblAttendenceMonthEnd => Set<AttendenceMonthEnd>();




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=HumanResourceInformationSystems;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
