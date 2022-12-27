using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class AdminSendMessage
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Customer")]
        public int CustmerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required, ForeignKey("Admin")]
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }

        [Required]
        [StringLength(200)]
        public string Message { get; set; }

    }
}
