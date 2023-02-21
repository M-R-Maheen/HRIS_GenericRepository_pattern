using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISdatabaseModels.DatabaseModels.SalaryStructure
{
    public partial class PayGradeScale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PayGradeScaleId { get; set; }

        [Required(ErrorMessage = "Grade   is required")]
        [Display(Name = "Grade")]
        public int GradeId { get; set; }

        [Required(ErrorMessage = " Salary Component  is required")]
        [Display(Name = "Salary Component")]
        public int ScId { get; set; }

        [Required(ErrorMessage = " Salary Component Amount  is required")]
        [Display(Name = "Salary Component Amount")]
        public decimal? ScAmount { get; set; }

    
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

        //public virtual Grade Grade { get; set; }
        //public virtual SalaryComponent Sc { get; set; }
    }
}
