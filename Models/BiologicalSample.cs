using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BYUArchaeologyEgypt.Models;

namespace BYUArchaeologyEgypt.Models
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

        //Added C14 Data into the Biological Samples table becaue we figure you can't take any Carbon data on something thats not a biological sample
        //Each sample has the details of it and possibility for C14 data for it

        public float Size { get; set; }

        public int Foci { get; set; }

        public int C14_2017 { get; set; }

        public string Location { get; set; }

        public string Questions { get; set; }

        public int ConventionalC14Age { get; set; }

        public int C14CalendarDate { get; set; }

        public int CalendarDateMAX { get; set; }

        public int CalendarDateMIN { get; set; }

        public int CalendarDateSPAN { get; set; }

        public int CalendarDateAVG { get; set; }

        public string Category { get; set; }


    }
}
