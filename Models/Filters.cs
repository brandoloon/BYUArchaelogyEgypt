using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models
{
    public class Filters
    {
        //Constructor for filter class setting all necessary inputs to all
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all-all-all-all----";
            string[] filters = FilterString.Split('-');
            HairColorId = filters[0];
            BurialWrapping = filters[1];
            AgeBracketAtDeath = filters[2];
            Sex = filters[3];
            BonesCollected = filters[4];
            HeadDirection = filters[5];
            YearFound = filters[6];
            //LocationNS = filters[6];
            //LocationEW = filters[7];
            //LocationNSLowerValue = filters[8];
            //LocationNSUpperValue = filters[9];
            //LocationEWLowerValue = filters[10];
            //LocationEWUpperValue = filters[11];
            //LocationSubplot = filters[12];
            Length = filters[7];
            Depth = filters[8];
            ArtifactDescription = filters[9];

        }
        public string FilterString { get; }
        public string HairColorId { get; }
        public string BurialWrapping { get; }
        public string AgeBracketAtDeath { get; }
        public string Sex { get; }
        public string BonesCollected { get; }
        public string YearFound { get; }
        public string Length { get; }
        public string Depth { get; }
        public string HeadDirection { get; }
        public string ArtifactDescription { get; }


        //Location values to filter by
        public string LocationNS { get; }
        public string LocationEW { get; }
        public string LocationNSLowerValue { get; }
        public string LocationNSUpperValue { get; }
        public string LocationEWLowerValue { get; }
        public string LocationEWUpperValue { get; }
        public string LocationSubplot { get; }





        //Boolean values to check if the user has input something to filter by
        public bool HasHairColor => HairColorId.ToLower() != "all";
        public bool HasBurialWrapping => BurialWrapping.ToLower() != "all";
        public bool HasAgeBracket => AgeBracketAtDeath.ToLower() != "all";
        public bool HasSex => Sex.ToLower() != "all";
        public bool HasBonesCollected => BonesCollected.ToLower() != "all";
        public bool HasYearFound => YearFound.ToLower() != "";
        public bool HasLength => Length.ToLower() != "";
        public bool HasDepth => Depth.ToLower() != "";
        public bool HasHeadDirection => HeadDirection.ToLower() != "all";
        public bool HasArtifactDescription => ArtifactDescription.ToLower() != "";



        //Sees if location filters are in place
        public bool HasLocationNS => LocationNS.ToLower() != "all";
        public bool HasLocationEW => LocationEW.ToLower() != "all";
        public bool HasLocationNSUpper => LocationNSUpperValue.ToLower() != "all";
        public bool HasLocationEWUpper => LocationEWUpperValue.ToLower() != "all";
        public bool HasLocationNSLower => LocationNSLowerValue.ToLower() != "all";
        public bool HasLocationEWLower => LocationEWLowerValue.ToLower() != "all";
        public bool HasLocationSubplot => LocationSubplot.ToLower() != "all";

    }
}
