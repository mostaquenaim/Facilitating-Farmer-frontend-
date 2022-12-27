using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class QuestionDTO
    {

            public int Id { get; set; }

            
            public string Query { get; set; }

            
            public DateTime DatePosted { get; set; }

            public int UserId { get; set; }
            
            public int CategoryId { get; set; }
            public virtual Category Category { get; set; }

        }
}
