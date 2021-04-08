using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models
{
    public class AgeAtDeath
    {
        [Key]
        public int AgeCode { get; set; }

        [Required]
        public string AgeDescription { get; set; }

    }
}
