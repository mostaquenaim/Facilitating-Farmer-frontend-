using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Description { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        public int CategoryId { get; set; }

        public CategoryDTO Category { get; set; }

        public int DifficultyId { get; set; }

        public DifficultyDTO Difficulty { get; set; }

    }
}
