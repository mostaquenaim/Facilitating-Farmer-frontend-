using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(256)]
        public string Query { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }

        [Required, ForeignKey("Customer")]
        public int UserId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required, ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Question()
        {
            
        }
    }
}
