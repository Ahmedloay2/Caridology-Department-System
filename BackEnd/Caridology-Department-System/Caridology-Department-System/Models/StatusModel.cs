﻿using System.ComponentModel.DataAnnotations;

namespace Caridology_Department_System.Models
{
    public class StatusModel
    {
        [Key]
        public int StatusID { get; set; } 
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }

}
