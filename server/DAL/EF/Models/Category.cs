using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Type { get; set; }

        public List<Course> Courses { get; set; }
        public List<Question> Question { get; set; }

        public Category()
        {
            Courses = new List<Course>();
            Question = new List<Question>();    
        }
    }
}
