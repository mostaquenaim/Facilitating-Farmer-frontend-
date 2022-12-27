using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MessageAdminDTO : AdminDTO
    {
        public List<AdminSendMessageDTO> AdminSendMessages { get; set; }

        public MessageAdminDTO()
        {
            AdminSendMessages = new List<AdminSendMessageDTO>();
        }

    }
}
