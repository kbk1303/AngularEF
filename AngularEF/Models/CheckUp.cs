using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularEF.Models
{
    public class CheckUp
    {
        [Key]
        [Required]
        public int CheckUpId { get; set; }

        [Required]
        public DateTime NextCheckUp { get; set; }

        /* reference properties - Registration */
        public int RegistrationId { get; set; }
        public Registration Registration { get; set; }


    }
}
