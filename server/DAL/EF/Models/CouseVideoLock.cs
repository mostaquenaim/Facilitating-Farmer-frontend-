using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class CouseVideoLock
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool IsLocked { get; set; }

        public List<CourseVideo> courseVideos { get; set; }

        public CouseVideoLock()
        {
            courseVideos = new List<CourseVideo>(); 
        }
    }
}
