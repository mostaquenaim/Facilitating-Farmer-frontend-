using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CourseEnrollmentDTO
    {
        internal DateTime LastUpdatedAt;

        public int Id { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public int RatingId { get; set; }

    }
}

