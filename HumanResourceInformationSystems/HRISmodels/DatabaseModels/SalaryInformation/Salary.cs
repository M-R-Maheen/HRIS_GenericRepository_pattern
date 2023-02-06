using HRIS.DatabaseModels.CompanyInformation;
using HRISdatabaseModels.DatabaseModels.CompanyInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRISdatabaseModels.DatabaseModels.SalaryInformation
{
    public class Salary
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalaryId { get; set; }

        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Salary Month Date")]
        public DateTime? SalaryMonthDate { get; set; }

        [Display(Name = "Employee Salary Component")]
        public int EscId { get; set; }

        [Display(Name = "Gross Pay")]
        public decimal? GrossPay { get; set; }

        [Display(Name = "Tax")]
        public decimal? Tax { get; set; }

        [Display(Name = "Net Pay Out")]
        public decimal? NetPayout { get; set; }

        [Display(Name = "State")]
        public int? StateId { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Create Date")]
        public DateTime? CreateDate { get; set; }

        [Display(Name = "Create By")]
        public int? CreateBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Last Update Date")]
        public DateTime? LastUpdateDate { get; set; }

        [Display(Name = "Upeated By")]
        public int? UpdateBy { get; set; }

        [Display(Name = "Approver")]
        public int? ApproverId { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Approve Date")]
        public DateTime? ApproveDate { get; set; }

        [Display(Name = "Company")]
        public int CompanyId { get; set; }

        [Display(Name = "Grade")]
        public int GradeId { get; set; }

        [Display(Name = "Designation")]
        public int DesignationId { get; set; }

        [Display(Name = "Division")]
        public int DivisionId { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Display(Name = "Lacation")]
        public int LocationId { get; set; }

        [Display(Name = "Employee Type")]
        public int EmployeeTypeId { get; set; }

        [Display(Name = "Bank Account No")]
        public string? BankAccountNo { get; set; }

        [Display(Name = "Salary Remarks")]
        public string? SalaryRemarks { get; set; }

        [Display(Name = "Payment By")]
        public int? PaymentBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Payment Date")]
        public DateTime? PaymentDate { get; set; }

        [Display(Name = "Is Bank Payment")]
        public int? IsBankPayment { get; set; }

        [Display(Name = "Bank Payment By")]
        public int? BankPaymentBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Bank Payment Date")]
        public DateTime? BankPaymentDate { get; set; }

        [Display(Name = "Is Cash Payment")]
        public int? IsCashPayment { get; set; }

        [Display(Name = "Cash Payment By")]
        public int? CashPaymentBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Cash Payment Date")]
        public DateTime? CashPaymentDate { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Payment Confirmation Date")]
        public DateTime? PaymentConfirmationDate { get; set; }

    }
}
