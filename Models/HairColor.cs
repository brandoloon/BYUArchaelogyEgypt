using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models
{
    public class HairColor
    {
        [Key]
        public int HairColorCode { get; set; }

        [Required]
        public string HairColorDescription { get; set; }

    }
}
