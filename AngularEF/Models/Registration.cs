using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularEF.Models
{
    public class Registration
    {
        [Key]
        [Required]
        public int RegistrationId { get; set; }

        [Required]
        public DateTime FirstDayRegistration { get; set; }

        [Required]
        public DateTime CurrentCheckUpDate { get; set; }

        [Required]
        [MaxLength(80)]
        public string RegistrationIdentifier { get; set; }

        /*reference properties Car*/
        public int CarId { get; set; }
        public Car Car { get; set; }

        /* reference properties Checkup */
        public List<CheckUp> CheckUps { get; set; }

    }
}
