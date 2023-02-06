using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Runtime.Serialization;

namespace HRISdatabaseModels.DatabaseModels.SalaryStructure

{ 
    public partial class EmployeeSalaryStructureDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EscDetailsId { get; set; }

        [ForeignKey("EmployeeSalaryStructure")]
        [Required(ErrorMessage = "Employee Salary Structure  is required")]
        [Display(Name = " Employee Salary Structure  ")]
        public int EssId { get; set; }

        [Required(ErrorMessage = " Salary Component  is required")]
        [Display(Name = "Salary Component")]
        public int ScId { get; set; }

        
        [Display(Name = "Salary Component value ")]
        public decimal? ScValue { get; set; }
        
        [Display(Name = "Effective Date")]
        [Column(TypeName ="date")]
        public DateTime? EffectiveDate { get; set; }

       
        [Display(Name = "Status")]
        public int? Status { get; set; }

       
        [Display(Name = "Created By")]
        public int? CreateBy { get; set; }
        [Display(Name = "Created Date")]
        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [Display(Name = "Update By")]
        public int? UpdateBy { get; set; }
        [Display(Name = "Update Date")]
        [Column(TypeName = "date")]
        public DateTime? UpdateDate { get; set; }

        //public virtual EmployeeSalaryStructure Esc { get; set; }
        //public virtual SalaryComponent Sc { get; set; }
    }
}

