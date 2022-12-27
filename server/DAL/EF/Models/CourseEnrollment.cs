using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class CourseEnrollment
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Customer")]
        public int StudentId  { get; set; }
        public virtual Customer Customer { get; set; }

        [Required, ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [Required, ForeignKey("Rating")]
        public int RatingId { get; set; }
        public virtual Rating Rating { get; set; }

    }
}
