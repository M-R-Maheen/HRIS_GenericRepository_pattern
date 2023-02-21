using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISdatabaseModels.DatabaseModels.AttendenceInformation
{
    public class LeaveType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeaveTypeId { get; set; }
        [Required(ErrorMessage = "Leave type is required!")]
        [Display(Name = "Leave Types")]
        public string TypeName { get; set; } = default!;
        [Required(ErrorMessage = "Leave type code is required!")]
        public string LeaveTypeCode { get; set; } = default!;
        [Display(Name ="Active")]
        public int? IsActive { get; set; }
        [Display(Name ="Created By")]
        public int? CreateBy { get; set; }
        [Display(Name ="Create Date")]
        [Column(TypeName="date")]
        public DateTime? CreateDate { get; set; }
        [Display(Name ="Updated By")]
        public int? UpdateBy { get; set; }
        [Display(Name ="Update Date")]
        [Column(TypeName ="date")]
        public DateTime? UpdateDate { get; set; }
    }
}
