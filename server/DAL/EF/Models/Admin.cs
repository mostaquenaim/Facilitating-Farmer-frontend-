using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public List<AdminSendMessage> adminSendMessages { get; set; }
        public List<AdminToken> AdminToken { get; set; }

        public Admin()
        {
            adminSendMessages = new List<AdminSendMessage>();
            AdminToken = new List<AdminToken>();
        }
    }
}
