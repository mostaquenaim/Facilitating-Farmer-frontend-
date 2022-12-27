using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SpecialistTokenDTO
    {
        public int ID { get; set; }

        public int SpecialistId { get; set; }

        public string TokenKey { get; set; }

        public System.DateTime CreatedAt { get; set; }

        public Nullable<System.DateTime> ExpiredAt { get; set; }
    }
}
