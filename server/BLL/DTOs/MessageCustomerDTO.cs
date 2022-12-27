using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MessageCustomerDTO : CustomerDTO
    {
        public List<AdminSendMessageDTO> AdminSendMessages { get; set; }

        public MessageCustomerDTO()
        {
            AdminSendMessages = new List<AdminSendMessageDTO>();
        }

    }
}
