using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all-all-all-";
            string[] filters = FilterString.Split('-');
            HairColorId = filters[0];
            BurialWrapping = filters[1];
            AgeBracketAtDeath = filters[2];
            Sex = filters[3];
            BonesCollected = filters[4];
            YearFound = filters[5];
        }
        public string FilterString { get; }
        public string HairColorId { get; }
        public string BurialWrapping { get; }
        public string AgeBracketAtDeath { get; }
        public string Sex { get; }
        public string BonesCollected { get; }
        public string YearFound { get; }


        public bool HasHairColor => HairColorId.ToLower() != "all";
        public bool HasBurialWrapping => BurialWrapping.ToLower() != "all";
        public bool HasAgeBracket => AgeBracketAtDeath.ToLower() != "all";
        public bool HasSex => Sex.ToLower() != "all";
        public bool HasBonesCollected => BonesCollected.ToLower() != "all";
        public bool HasYearFound => YearFound.ToLower() != "";
    }
}
