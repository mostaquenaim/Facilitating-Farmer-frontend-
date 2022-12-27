using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Specialist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        public int Verified { get; set; }

        public List<CourseInstructorMap> CourseInstructorMaps { get; set; }
        public List<Answer> Answers { get; set; }
        public List<SpecialistToken> SpecialistTokens { get; set; }

        public Specialist()
        {
            CourseInstructorMaps = new List<CourseInstructorMap>();
            Answers = new List<Answer>();
            SpecialistTokens = new List<SpecialistToken>();
        }
    }
}
