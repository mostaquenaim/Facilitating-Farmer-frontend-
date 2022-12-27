using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CategoryCourseDTO : CategoryDTO
    {
        public List<CourseDTO> Courses { get; set; }

        public CategoryCourseDTO()
        {
            Courses = new List<CourseDTO>();
        }
    }
}
