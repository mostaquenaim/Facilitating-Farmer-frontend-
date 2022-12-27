using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminSendMessageSummaryDTO
    {

        public int Id { get; set; }


        
        public CustomerDTO Customer { get; set; }


        
        public AdminDTO Admin { get; set; }

        public string Message { get; set; }
    }
}
