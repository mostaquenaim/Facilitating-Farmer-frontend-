using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class SpecialistToken
    {
        [Key]
        public int ID { get; set; }

        [Required, ForeignKey("Specialist")]
        public int SpecialistId { get; set; }
        public virtual Specialist Specialist { get; set; }

        [Required]
        [StringLength(50)]
        public string TokenKey { get; set; }

        [Required]
        public System.DateTime CreatedAt { get; set; }
        
        public Nullable<System.DateTime> ExpiredAt { get; set; }


    }
}
