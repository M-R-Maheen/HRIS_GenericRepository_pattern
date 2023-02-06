using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISdatabaseModels.DatabaseModels.AttendenceInformation
{
    public class DailyAttendence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceId { get; set; }
        [Required(ErrorMessage ="Employee required!")]
        [Display(Name ="Employee")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Company required!")]
        [Display(Name = "Company")]


        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Grade required!")]
        [Display(Name = "Grade")]


        public int GradeId { get; set; }
        [Required(ErrorMessage = "Designation required!")]
        [Display(Name = "Designation")]


        public int DesignationId { get; set; }
        [Required(ErrorMessage = "Division required!")]
        [Display(Name = "Division")]


        public int DivisionId { get; set; }
        [Required(ErrorMessage = "Department required!")]
        [Display(Name = "Department")]


        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Location required!")]
        [Display(Name = "Location")]


        public int LocationId { get; set; }
        [Required(ErrorMessage = "Roster required!")]
        [Display(Name = "Roster")]


        public int RosterId { get; set; }
        [Required(ErrorMessage ="Date is required!")]
        [Column(TypeName ="date")]
        [Display(Name ="Attendence Date")]

        public DateTime? AttendanceDate { get; set; }
        [Required(ErrorMessage = "Log In Time Required!")]
        [Display(Name = "Log In")]
        public string LoginTime { get; set; } = default!;
        [Required(ErrorMessage = "Log Out Time Required!")]
        [Display(Name = "Log Out")]


        public string LogoutTime { get; set; }
        
        public int? Status { get; set; }
        [Display(Name ="Holiday")]
        public int? IsHoliDay { get; set; }
        [Display(Name = "Entry")]
        public string RosterIntime { get; set; } = default!;
        [Display(Name = "Leave")]
        public string RosterOutTime { get; set; } = default!;

        public decimal? GraceIn { get; set; }
        public decimal? GraceOut { get; set; }
        public int? CreateBy { get; set; }
        [Display(Name ="Create Date")]
        [Column(TypeName ="date")]
        public DateTime? CreateDate { get; set; }
        [Display(Name ="Updated By")]
        public int? UpdateBy { get; set; }
        [Display(Name ="Update Date")]
        [Column(TypeName ="date")]
        public DateTime? UpdateDate { get; set; }
    }
}
