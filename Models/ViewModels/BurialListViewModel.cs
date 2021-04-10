using BYUArchaeologyEgypt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Views.ViewModels
{
    public class BurialListViewModel
    {
        public List<Burial> Burials { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public List<Burial> tasks { get; set; }
    }
}