using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Customer
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

        public List<CourseEnrollment> courseEnrollments { get; set; }
        public List<Question> questions { get; set; }
        public List<CustomerToken> CustomerTokens { get; set; }

        public Customer()
        {
            courseEnrollments = new List<CourseEnrollment>();
            questions = new List<Question>();
            CustomerTokens = new List<CustomerToken>();


        }

    }
}
