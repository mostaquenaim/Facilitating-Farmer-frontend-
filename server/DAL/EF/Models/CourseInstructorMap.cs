using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class CourseInstructorMap
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [Required, ForeignKey("Specialist")]
        public int InstructorId { get; set; }
        public virtual Specialist Specialist { get; set; }
    }
}
