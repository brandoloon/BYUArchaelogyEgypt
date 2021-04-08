using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        public string BurialLocationNS { get; set; }
        
        [Required]
        public string BurialLocationEW { get; set; }

        [Required]
        public string LowPairNS { get; set; }

        [Required]
        public string HighPairNS { get; set; }

        [Required]
        public string LowPairEW { get; set; }

        [Required]
        public string HighPairEW { get; set; }

        [Required]
        public string Subplot { get; set; }

    }
}
