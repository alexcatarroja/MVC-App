using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltest.Models
{
    public class State
    { 
        // Data annotation

        [Key]

        [Required]
        // Modeling the fields 
        public int Id { get; set; }

        [Display(Name = "State")]
        // Requiring a field 
        [Required(ErrorMessage ="Name of State is Required")]

        // Calling the Max Length value from ContactWeb Constants
        [StringLength(ContactWebConstants.MAX_STATE_NAME_LENGTH)]

        public string Name { get; set; }

        [Display(Name = "Abbreviation")]
        [Required(ErrorMessage = "State Abbreviation is Required")]
        [StringLength(ContactWebConstants.MAX_STATE_ABBR_LENGTH)]

        public string Abbreviation { get; set; }
    }
}
