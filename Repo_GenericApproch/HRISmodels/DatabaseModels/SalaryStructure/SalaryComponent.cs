using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRISdatabaseModels.DatabaseModels.SalaryStructure
{
    public partial class SalaryComponent
    {
        //public SalaryComponent()
        //{
        //    EmployeeSalaryStructureDetails = new HashSet<EmployeeSalaryStructureDetails>();
        //    PayGradeScale = new HashSet<PayGradeScale>();
        //    SalaryDetails = new HashSet<SalaryDetails>();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScId { get; set; }
        [Required(ErrorMessage = " Salary Component Code is required")]
        [Display(Name = "Salary Component Code ")]
        public string ScCode { get; set; }

        [Required(ErrorMessage = " Salary Component Name is required")]
        [Display(Name = "Salary Structure Name ")]
        public string ScName { get; set; }
        [Required(ErrorMessage = " Salary Component Type is required")]
        [Display(Name = "Salary Component Type ")]
        public int? ScType { get; set; }
        [Display(Name = "Is Active")]
        public int IsActive { get; set; }
       
        [Display(Name = "Created Bye")]
        public int? CreateBy { get; set; }

        [Display(Name = "Created Date")]
        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }
       
        [Display(Name = "Update By")]
        public int? UpdateBy { get; set; }

        [Display(Name = "Update Date")]
        [Column(TypeName = "date")]
        public DateTime? UpdateDate { get; set; }



        [Display(Name = "Is Bonus")]
        public int? IsBonus { get; set; }

        [Display(Name = "Bonus Eligibility")]
        public int? BonusEligibility { get; set; }

        //public virtual ICollection<EmployeeSalaryStructureDetails> EmployeeSalaryStructureDetails { get; set; }
        //public virtual ICollection<PayGradeScale> PayGradeScale { get; set; }
        //public virtual ICollection<SalaryDetails> SalaryDetails { get; set; }
    }
}
