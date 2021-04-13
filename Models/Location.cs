using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Burial Location: North or South")]
        public string BurialLocationNS { get; set; }
        [Required]
        [DisplayName("Burial Location: East or West")]
        public string BurialLocationEW { get; set; }
        [Required]
        [DisplayName("Low Pair: North or South")]
        public string LowPairNS { get; set; }
        [Required]
        [DisplayName("High Pair: North or South")]
        public string HighPairNS { get; set; }
        [Required]
        [DisplayName("Low Pair: East or West")]
        public string LowPairEW { get; set; }
        [Required]
        [DisplayName("High Pair: East or West")]
        public string HighPairEW { get; set; }
        [Required]
        public string Subplot { get; set; }

    }
}
