using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class AdminToken
    {
        [Key]
        public int ID { get; set; }

        [Required, ForeignKey("Admin")]
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }

        [Required]
        [StringLength(50)]
        public string TokenKey { get; set; }

        [Required]
        public System.DateTime CreatedAt { get; set; }
        
        public Nullable<System.DateTime> ExpiredAt { get; set; }
    }
}
