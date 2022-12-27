using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DifficultyCourseDTO : DifficultyDTO
    {
        public List<CourseDTO> Courses { get; set; }

        public DifficultyCourseDTO()
        {
            Courses = new List<CourseDTO>();
        }
    }
}
