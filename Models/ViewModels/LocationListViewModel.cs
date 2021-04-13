using BYUArchaeologyEgypt.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models.ViewModels
{
    public class LocationListViewModel
    {
        public List<Location> Locations { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
    }
}
