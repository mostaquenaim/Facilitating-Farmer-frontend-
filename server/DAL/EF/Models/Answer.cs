using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(256)]
        public string Comment { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }

        [Required]
        public int Likes { get; set; }

        [Required]
        public int Dislikes { get; set; }

        [Required, ForeignKey("Question")]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }

        [Required, ForeignKey("Specialist")]
        public int SpecialistId { get; set; }
        public virtual Specialist Specialist { get; set; }

        public Answer()
        {
            
        }

    }
}
