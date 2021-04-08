using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models
{
    public class BurialWrapping
    {
        [Key]
        public int BurialWrappingCode { get; set; }

        [Required]
        public string BurialWrappingDescription { get; set; }

    }
}
