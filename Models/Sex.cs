using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaelogyEgypt.Models
{
    public class Sex
    {
        [Key]
        public int SexCode { get; set; }

        [Required]
        public string SexDescription { get; set; }

    }
}
