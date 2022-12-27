using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminSendMessageDTO
    {
        
        public int Id { get; set; }

        
        public int CustmerId { get; set; }
        public CustomerDTO Customer { get; set; }

        
        public int AdminId { get; set; }
        public AdminDTO Admin { get; set; }

        public string Message { get; set; }
    }
}
