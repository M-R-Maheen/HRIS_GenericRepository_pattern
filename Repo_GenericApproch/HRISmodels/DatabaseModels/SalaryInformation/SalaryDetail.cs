using HRISdatabaseModels.DatabaseModels.Loan;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRISdatabaseModels.DatabaseModels.SalaryInformation
{
    public class SalaryDetail
    {
        public SalaryDetail()
        {
            this.Salaries= new HashSet<Salary>();
        }

        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = " Salary Details Id")]
        public int SalaryDetailsId { get; set; }

        [ForeignKey("Salary")]  //Foreign Key
        [Display(Name = "Salary ID")]
        public int SalaryId { get; set; }

        [Display(Name = "Salary Component Id")]
        public int ScId { get; set; }

        [Display(Name = "Salary Component Amount")]
        public decimal? ScAmount { get; set; }

        [Display(Name = "Salary Component Type")]
        public int? ScType { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " SalaryMonth Date")]
        public DateTime? SalaryMonthDate { get; set; }

        public int? LoanScheduleId { get; set; }

        public decimal? Arear { get; set; }

        public int? CreateBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Create Date ")]
        public DateTime? CreateDate { get; set; }

        public int? UpdateBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = " Create Date ")]
        public DateTime? UpdateDate { get; set; }

        //nev
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
