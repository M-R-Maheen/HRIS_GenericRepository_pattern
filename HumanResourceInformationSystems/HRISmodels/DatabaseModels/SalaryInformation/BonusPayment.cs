using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISdatabaseModels.DatabaseModels.SalaryInformation
{
    public class BonusPayment
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Bonus Payment ID")]
        public int BonusPaymentId { get; set; }

        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }

        [Display(Name = "Salary Component Id")]
        public int ScId { get; set; }

        [Display(Name = "Salary Component Amount")]
        public decimal? ScAmount { get; set; }

        [Display(Name = "Net Payout")]
        public decimal? NetPayout { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Payment Month Date")]
        public DateTime? PaymentMonthDate { get; set; }

        [Display(Name = "Generate By")]
        public int? GenerateBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Generate Date")]
        public DateTime? GenerateDate { get; set; }

        [Display(Name = "Approve By")]
        public int? ApproveBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Approve Date")]
        public DateTime? ApproveDate { get; set; }

        [Display(Name = "Payment By")]
        public int? PaymentBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Payment Date")]
        public DateTime? PaymentDate { get; set; }

        [Display(Name = "Status")]
        public int? StatusId { get; set; }

        [Display(Name = "Bank")]
        public int? BankId { get; set; }

        [Display(Name = "Branch")]
        public int? BranchId { get; set; }

        [Display(Name = "Account No")]
        public string? AccountNo { get; set; }

        [Display(Name = "Company")]
        public int? CompanyId { get; set; }

        [Display(Name = "Location")]
        public int? LocationId { get; set; }

        [Display(Name = "Department")]
        public int? DepartmentId { get; set; }

        [Display(Name = "Designation")]
        public int? DesignationId { get; set; }

        [Display(Name = "Employee Type")]
        public int? EmployeeTypeId { get; set; }

        [Display(Name = "Bank Account No")]
        public string? BankAccountNo { get; set; }

        [Display(Name = "Grade")]
        public int? GradeId { get; set; }

        [Display(Name = "Division")]
        public int? DivisionId { get; set; }

        [Display(Name = "Remarks")]
        public string? Remarks { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cut Of Date")]
        public DateTime? CutOffDate { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Payment Confirmation Date")]
        public DateTime? PaymentConfirmationDate { get; set; }
    }
}
