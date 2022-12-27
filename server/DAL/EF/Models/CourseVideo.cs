using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class CourseVideo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Video { get; set; }

        [Required]
        public int Serial { get; set; }


        [Required, ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [Required, ForeignKey("CouseVideoLock")]
        public int IsLockedId {get; set; }
        public virtual CouseVideoLock CouseVideoLock { get; set; }
    }
}
