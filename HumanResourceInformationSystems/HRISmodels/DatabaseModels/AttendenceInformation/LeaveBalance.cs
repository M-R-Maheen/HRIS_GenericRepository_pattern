using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISdatabaseModels.DatabaseModels.AttendenceInformation
{
    public class LeaveBalance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeaveBalanceId { get; set; }
        [Required(ErrorMessage ="Employee is required!")]
        [Display(Name ="Employee ID")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Leave Type is required!")]
        [Display(Name = "Leave ID")]


        public int LeaveTypeId { get; set; }
        [Display(Name ="Leave Balance open")]
        public decimal? OpeningLeaveBalance { get; set; }
        [Display(Name ="Leave spend")]
        public decimal? SpendedLeave { get; set; }
        [Display(Name ="Leave Balance Close")]
        public decimal? ClosingBalance { get; set; }
        public int? Year { get; set; }
        [Display(Name ="Created By")]
        public int? CreateBy { get; set; }
        [Column(TypeName ="date")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "Updated By")]

        public int? UpdateBy { get; set; }
        [Column(TypeName = "date")]

        public DateTime? UpdateDate { get; set; }

    }
}
