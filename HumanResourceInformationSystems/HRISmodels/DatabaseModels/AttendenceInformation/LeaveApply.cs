using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISdatabaseModels.DatabaseModels.AttendenceInformation
{
    public class LeaveApply
    {
        [Key]
        [Display(Name ="ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeLeaveId { get; set; }
        [Required(ErrorMessage ="Employee is required!")]
        [Display(Name ="Employee ID")]
        public int EmployeeId { get; set; }

        public int? Year { get; set; }
        [Display(Name ="Leave Type ID")]
        public int? LeaveTypeId { get; set; }
        [Display(Name ="Apply Date")]
        public DateTime? LeaveApplyDate { get; set; }
        [Display(Name = "Reason")]
        public string LeaveReason { get; set; } = default!;
        [Display(Name ="Approved By")]
        public int? LeaveApprovedBy { get; set; }
        public int? Status { get; set; }
        [Display(Name ="Create date")]
        [Column(TypeName ="date")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "Update date")]

        [Column(TypeName = "date")]

        public DateTime? UpdateDate { get; set; }
        [Display(Name ="Created By")]
        public int? CreateBy { get; set; }
        [Display(Name ="Updated By")]
        public int? UpdateBy { get; set; }

    }
}
