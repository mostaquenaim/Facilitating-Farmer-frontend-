﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SpecialistDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required,StringLength(50)]
        public string Username { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(100)]
        public string Password { get; set; }
    }
}
