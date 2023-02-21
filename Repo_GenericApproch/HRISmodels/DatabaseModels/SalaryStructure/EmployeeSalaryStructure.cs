using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISdatabaseModels.DatabaseModels.SalaryStructure
{
    public partial class EmployeeSalaryStructure
    {
        //public EmployeeSalaryStructure()
        //{
        //    EmployeeSalaryStructureDetails = new HashSet<EmployeeSalaryStructureDetails>();
        //    Salary = new HashSet<Salary>();
        //}
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EssId { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [Display(Name = "Employee Name")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee Type  is required")]
        [Display(Name = "EmployeeType")]
        public int EmployeeTypeId { get; set; }

        [Required(ErrorMessage = "Grade   is required")]
        [Display(Name = "Grade")]
        public int GradeId { get; set; }
       
        [Display(Name = "Gross Pay ")]
        public decimal? GrossPay { get; set; }
        
        [Display(Name = "Net Tax Payable ")]
        public decimal? NetTaxPayable { get; set; }
       
        [Display(Name = "Approve Bye")]
        public int? EscApprobedBy { get; set; }
      
        [Display(Name = "Approve Date")]
        [Column(TypeName = "date")]
        public DateTime? EscApproveDate { get; set; }
    
        [Display(Name = "Effective Date")]
        [Column(TypeName = "date")]
        public DateTime? EscEffectiveDate { get; set; }

        [Display(Name = "Status")]
        public int? Status { get; set; }

        [Display(Name = "Created By")]
        public int? CreateBy { get; set; }

        [Display(Name = "Created Date")]
        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        //public virtual Employee Employee { get; set; }
        //public virtual EmployeeType EmployeeType { get; set; }
        //public virtual Grade Grade { get; set; }
        //public virtual ICollection<EmployeeSalaryStructureDetails> EmployeeSalaryStructureDetails { get; set; }
        //public virtual ICollection<Salary> Salary { get; set; }
    }
}
