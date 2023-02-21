using HRIS.DatabaseContext;
using HRIS.Interfaces;
using HRIS.Interfaces.CompanyInterfaces;
using HRIS.Repositories.CompanyRepositories;
using HRISgenericInterfaces.AttendenceInterfaces;
using HRISgenericInterfaces.CompanyInterfaces;
using HRISgenericInterfaces.EmployeeTaxAndLoanInterfaces;
using HRISgenericInterfaces.LoanInterfaces;
using HRISgenericInterfaces.SalaryIntercaces;
using HRISgenericInterfaces.SalaryStructureInterfaces;
using HRISgenericRepositories.AttendenceRepositary;
using HRISgenericRepositories.CompanyRepositories;
using HRISgenericRepositories.EmployeeTaxAndLoanRepositories;
using HRISgenericRepositories.SalaryRepositories;
using HRISgenericRepositories.SalaryStructureRepositories;

namespace HRIS.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICompanyRepository companyRepository { get; private set; }
        public IGradeRepository gradeRepository { get; private set; }
        public IDesignationRepository designationRepository { get; private set; }
        public IDivisionRepository divisionRepository { get; private set; }
        public IDepartmentRepository departmentRepository { get; private set; }
        public ILocationRepository locationRepository { get; private set; }
        public IRosterRepository rosterRepository { get; private set; }

        //Nur vai
        public IEmployeeTaxInfoRepository employeeTaxInfoRepository { get; private set; }
        public ILoanInformationRepository loanInformationRepository { get; private set; }
        public ILoanScheduleRepository loanScheduleRepository { get; private set; }
        public ILoanTypeRepository loanTypeRepository { get; private set; }

        //salary Mamunur Roshid
        public ISalaryRepository salaryRepository { get; private set; }
        public ISalaryDetailRepository salaryDetailRepository { get; private set; }
        public IBonusPaymentRepository bonusPaymentRepository { get; private set; }

        //Rahima Akter
        public IEmployeeSalaryStructure employeeSalaryStructureRepo { get; private set; }
        public IEmployeeSalaryStructureDetails employeeSalaryStructureDetailRepo { get; private set; }
        public IPayGradeScale payGradeScaleRepo { get; private set; }
        public ISalaryComponent salaryComponentRepo { get; private set; }

        //--Mumu
        public IDailyAttendenceRepositary dailyAttendenceRepositary { get; private set; }
        public ILeaveTypeRepositary leaveTypeRepositary { get; private set; }
        public ILeaveApplyRepositary leaveApplyRepositary { get; private set; }
        public ILeaveBalanceRepositary leaveBalanceRepositary { get; private set; }
        public IAttendenceMonthEndRepositary attendenceMonthEndRepositary { get; private set; }

        private readonly HRISdbContext hrisDbContext;
        public UnitOfWork(HRISdbContext DbContext)
        {
            this.hrisDbContext = DbContext;



            companyRepository = new CompanyRepository(hrisDbContext);
            gradeRepository = new GradeRepository(hrisDbContext);
            designationRepository = new DesignationRepository(hrisDbContext);
            divisionRepository = new DivisionRepository(hrisDbContext);
            departmentRepository = new DepartmentRepository(hrisDbContext);
            locationRepository = new LocationRepository(hrisDbContext);
            rosterRepository = new RosterRepository(hrisDbContext);

            //Nur Vai
            employeeTaxInfoRepository = new EmployeeTaxInfoRepository(hrisDbContext);
            loanInformationRepository = new LoanInfoRepository(hrisDbContext); 
            loanScheduleRepository=new LoanScheduleRepository(hrisDbContext);
            loanTypeRepository = new LoanTypeRepository(hrisDbContext);

            //Salary
            salaryRepository = new SalaryRepository(hrisDbContext);
            salaryDetailRepository = new SalaryDetailRepository(hrisDbContext);
            bonusPaymentRepository = new BonusPaymentRepository(hrisDbContext);

            //Rahima Akter
            employeeSalaryStructureRepo = new EmployeeSalaryStructureRepo(hrisDbContext);
            employeeSalaryStructureDetailRepo = new EmployeeSalaryStructureDetailRepo(hrisDbContext);
            payGradeScaleRepo = new PayGradeScaleRepo(hrisDbContext);
            salaryComponentRepo = new SalaryComponenetRepo(hrisDbContext);

            //Mumu
            dailyAttendenceRepositary = new DailyAttendencesRepositary(hrisDbContext);
            leaveTypeRepositary = new LeaveTypeRepositary(hrisDbContext);
            leaveApplyRepositary = new LeaveApplyRepositary(hrisDbContext);
            leaveBalanceRepositary = new LeaveBalanceRepositary(hrisDbContext);
            attendenceMonthEndRepositary = new AttendenceMonthEndRepositary(hrisDbContext);

        }

        public async Task CompleteAsync()
        {
            await hrisDbContext.SaveChangesAsync();
        }
    }
}
