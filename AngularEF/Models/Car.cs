using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularEF.Models
{
    public class Car
    {
        [Key]
        [Required]
        public int CarId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Manufacture { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [MaxLength(20)]
        public string Type { get; set; }

        [Required]
        [MaxLength(20)]
        public DateTime ProductionDate { get; set; }

        /*reference properties Registration */
        public Registration Registration { get; set; }

        /* reference properties Car */
        public ICollection<Owner> Owners { get; set; }


    }
}
