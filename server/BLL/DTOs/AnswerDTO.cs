using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AnswerDTO
    {
        
        public int Id { get; set; }

        public string Comment { get; set; }

        public DateTime DatePosted { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public int QuestionId { get; set; }
        

        public int SpecialistId { get; set; }
        public DateTime LastUpdatedAt { get; internal set; }
    }
}
