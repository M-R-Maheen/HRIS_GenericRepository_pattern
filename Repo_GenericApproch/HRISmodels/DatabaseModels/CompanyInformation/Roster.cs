using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRISdatabaseModels.DatabaseModels.CompanyInformation
{
    public class Roster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Roster ID")]
        public int RosterId { get; set; }


        [Required(ErrorMessage ="Roster Month is required")]
        [Display(Name = "Roster Month")]
        [StringLength(30)]
        public string RosterMonth { get; set; }


        [Required(ErrorMessage ="Location Name is required")]
        [ForeignKey("Location")]
        [Display(Name = "Location Name")]
        public int LocationId { get; set; }


        [Required(ErrorMessage ="Roster InTime is required")]
        [Display(Name = "Roster InTime")]
        public string RosterIntime { get; set; }


        [Required(ErrorMessage = "Roster OutTime is required")]
        [Display(Name = "Roster OutTime")]
        public string RosterOuttime { get; set; }


        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Is Active")]
        public int IsActive { get; set; }


        [Display(Name = "Created By")]
        public string? CreateBy { get; set; }


        [Display(Name = "Created Date")]
        public DateTime CreateDate { get; set; } = DateTime.Now;


        [Display(Name = "Updated By")]
        public string? UpdateBy { get; set; }


        [Display(Name = "Updated Date")]
        public DateTime UpdateDate { get; set; } = DateTime.Now;

    }
}
