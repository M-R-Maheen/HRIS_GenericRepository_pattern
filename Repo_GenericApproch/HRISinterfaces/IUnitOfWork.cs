using HRIS.Interfaces.CompanyInterfaces;
using HRISgenericInterfaces.AttendenceInterfaces;
using HRISgenericInterfaces.CompanyInterfaces;
using HRISgenericInterfaces.EmployeeTaxAndLoanInterfaces;
using HRISgenericInterfaces.LoanInterfaces;
using HRISgenericInterfaces.SalaryIntercaces;
using HRISgenericInterfaces.SalaryStructureInterfaces;

namespace HRIS.Interfaces
{
    public interface IUnitOfWork

    {
        ICompanyRepository companyRepository { get; }
        IGradeRepository gradeRepository { get; }
        IDesignationRepository designationRepository { get; }
        IDivisionRepository divisionRepository { get; }
        IDepartmentRepository departmentRepository { get; }
        ILocationRepository locationRepository { get; }
        IRosterRepository rosterRepository { get; }

        //Nur Vai
        IEmployeeTaxInfoRepository employeeTaxInfoRepository { get; }
        ILoanInformationRepository loanInformationRepository { get; }
        ILoanScheduleRepository loanScheduleRepository { get; }
        ILoanTypeRepository loanTypeRepository { get; }

        //Mamunur Roshid
        ISalaryRepository salaryRepository { get; }
        ISalaryDetailRepository salaryDetailRepository { get; }
        IBonusPaymentRepository bonusPaymentRepository { get; }

        //Rahima Akter
        IEmployeeSalaryStructure employeeSalaryStructureRepo { get; }
        IEmployeeSalaryStructureDetails employeeSalaryStructureDetailRepo { get; }
        IPayGradeScale payGradeScaleRepo { get; }
        ISalaryComponent salaryComponentRepo { get; }

        //Mumu
        IDailyAttendenceRepositary dailyAttendenceRepositary { get; }
        ILeaveTypeRepositary leaveTypeRepositary { get; }
        ILeaveApplyRepositary leaveApplyRepositary { get; }
        ILeaveBalanceRepositary leaveBalanceRepositary { get; }
        IAttendenceMonthEndRepositary attendenceMonthEndRepositary { get; }

        Task CompleteAsync();
    }
}
