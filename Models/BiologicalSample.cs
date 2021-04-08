using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BYUArchaelogyEgypt.Models;

namespace BYUArchaelogyEgypt.Models
{
    public class BiologicalSample
    {
        [Key]
        public int SampleId { get; set; }

        [ForeignKey("Burial")]
        public int Burial { get; set; }

        public int RackNum { get; set; }

        public int BagNum { get; set; }

        public int ClusterNumber { get; set; }

        public DateTime DateFound { get; set; }

        public bool PreviouslySampled { get; set; }

        public string Notes { get; set; }

        public string Initials { get; set; }

        public string Area { get; set; }


    }
}
