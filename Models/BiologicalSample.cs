using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Rack Number")]
        public int RackNum { get; set; }

        [DisplayName("Bag Number")]
        public int BagNum { get; set; }

        [DisplayName("Cluster Number")]
        public int ClusterNumber { get; set; }

        [DisplayName("Date Found")]
        public DateTime DateFound { get; set; }

        [DisplayName("Previously Sampled?")]
        public bool PreviouslySampled { get; set; }

        public string Notes { get; set; }

        public string Initials { get; set; }

        public string Area { get; set; }

        //Added C14 Data into the Biological Samples table becaue we figure you can't take any Carbon data on something thats not a biological sample
        //Each sample has the details of it and possibility for C14 data for it

        public float Size { get; set; }

        public int Foci { get; set; }

        [DisplayName("C14 2017")]
        public int C14_2017 { get; set; }

        public string Location { get; set; }

        public string Questions { get; set; }

        [DisplayName("Conventional C14 Age")]
        public int ConventionalC14Age { get; set; }

        [DisplayName("C14 Calendar Date")]
        public int C14CalendarDate { get; set; }

        [DisplayName("Calendar Date Max")]
        public int CalendarDateMAX { get; set; }

        [DisplayName("Calendar Date Min")]
        public int CalendarDateMIN { get; set; }

        [DisplayName("Calendar Date Span")]
        public int CalendarDateSPAN { get; set; }

        [DisplayName("Calendar Date Avg")]
        public int CalendarDateAVG { get; set; }

        public string Category { get; set; }

    }
}
