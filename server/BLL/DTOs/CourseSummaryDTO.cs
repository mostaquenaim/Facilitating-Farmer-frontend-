using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CourseSummaryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Description { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        public CategoryDTO Category { get; set; }

        public DifficultyDTO Difficulty { get; set; }
    }
}
