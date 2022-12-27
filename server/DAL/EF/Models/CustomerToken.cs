using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class CustomerToken
    {
        [Key]
        public int ID { get; set; }

        [Required, ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required]
        [StringLength(50)]
        public string TokenKey { get; set; }

        [Required]
        public System.DateTime CreatedAt { get; set; }
        
        public Nullable<System.DateTime> ExpiredAt { get; set; }

        
    }
}
