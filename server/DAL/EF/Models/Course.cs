using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required,StringLength(100)]
        public string Subtitle { get; set; }

        [Required,StringLength(256)]
        public string Description { get; set; }

        [Required]
        public DateTime LastUpdatedAt { get; set; }

        [Required, ForeignKey("Difficulty")]
        public int DifficultyId { get; set; }
        public virtual Difficulty Difficulty { get; set; }

        [Required, ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public List<CourseInstructorMap> CourseInstructorMaps { get; set; }
        public List<CourseVideo> CourseVideos { get; set; }
        public List<CourseEnrollment> CourseEnrollments { get; set; }

        public Course()
        {
            CourseInstructorMaps = new List<CourseInstructorMap>();
            CourseVideos = new List<CourseVideo>();
            CourseEnrollments = new List<CourseEnrollment>();
        }
    }
}
