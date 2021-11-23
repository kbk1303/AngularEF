using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularEF.Models
{
    public class Owner
    {
        [Key]
        [Required]
        public int OwnerId { get; set; }

        [Required]
        [MaxLength(11)]
        public string cpr { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        /* reference properties Car */
        public ICollection<Car> Cars { get; set; }

    }
}
