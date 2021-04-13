using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Models
{
    /* GENERAL NOTES
     
       CLUSTER FEATURE AND DATA SET 
            Not, we chose to ignore the cluster feature as the cluster
            database held only repetitve informtion
       Reequired Vs No
            In the data sets, if the features HAD values for every entry,
            we made that feature requireed in the model. If the feature did
            NOT HAVE values for every entry we made the feature not required in the model
    */


    public class Burial
    {
        [Key]
        public int BurialID { get; set; }
        [Required]
        [DisplayName("Burial Number")]
        public int Tomb_number { get; set; }
        [ForeignKey("Location")]
        public int Location { get; set; }
        [Required]
        [DisplayName("Area Hill Burials")]
        //We made this a string in the case that a researcher enters a character
        //We felt that it was a likely occurence. Moreover, no mathmatical operations
        //will be run on these values
        public string Area_hill_burials { get; set; }
        [DisplayName("Burial Depth")]
        [Required]
        public int Burial_depth { get; set; }
        [DisplayName("South to Head")]
        [Required]
        public float South_to_head { get; set; }
        [DisplayName("South to Feet")]
        [Required]
        public float South_to_feet { get; set; }
        [DisplayName("West to Head")]
        [Required]
        public float West_to_head { get; set; }
        [DisplayName("West to Head")]
        [Required]
        public float West_to_feet { get; set; }
        [DisplayName("Length of Remains")]
        public int Length_of_remains { get; set; }
        [DisplayName("Sample Number")]
        public int Sample_number { get; set; }        
        [Required]
        public bool Artifact_found { get; set; }
        [DisplayName("Artifact's Description")]
        public string Artifacts_description { get; set; }
        [DisplayName("Hair Taken")]
        [Required]
        public bool Hair_taken { get; set; }
        [DisplayName("Soft Tissue")]
        [Required]
        public bool Soft_tissue { get; set; }
        [DisplayName("Bone Taken")]
        [Required]
        public bool Bone_taken { get; set; }
        [DisplayName("Tooth Taken")]
        [Required]
        public bool Tooth_taken { get; set; }
        [DisplayName("Textile Taken")]
        [Required]
        public bool Texile_taken { get; set; }
        [DisplayName("Description of Taken")]
        public string Description_of_taken { get; set; }
        [DisplayName("GE Function")]
        [Required]
        public float GE_function { get; set; }
        [DisplayName("Burial Situation")]
        public string Burial_situation { get; set; }
        [DisplayName("Sex")]
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Sex_Method { get; set; }
        [DisplayName("Hair Color")]
        [Required]
        public string Hair_color { get; set; }
        [Required]
        public string Burial_wrapping { get; set; }
        public string Preservation { get; set; }
        [DisplayName("Age Bracket at Death")]
        [Required]
        public string Age_bracket_at_death { get; set; }
        public int Estimated_age_at_death { get; set; }
        [DisplayName("Age Method")]
        public string Age_Method { get; set; }
        [DisplayName("Estimate Living Stature")]
        public int Estimate_living_stature { get; set; }
        [DisplayName("Year Found")]
        [Required]
        public int Year_found { get; set; }
        [DisplayName("Month Found")]
        [Required]
        public int Month_found { get; set; }
        [DisplayName("Day Found")]
        [Required]
        public int Day_found { get; set; }
        [DisplayName("Head Direction")]
        public string Head_direction { get; set; }
        [DisplayName("Basilar Suture")]
        [Required]
        public string Basilar_suture { get; set; }
        [DisplayName("Ventral Arc")]
        [Required]
        public int Ventral_arc { get; set; }
        [DisplayName("Subpubic Angle")]
        [Required]
        public int Subpubic_angle { get; set; }
        [DisplayName("Sciatic Notch")]
        [Required]
        public int Sciatic_notch { get; set; }
        [DisplayName("Pubic Bone")]
        [Required]
        public int Public_bone { get; set; }
        [DisplayName("Preaur Sulcus")]
        [Required]
        public int Preaur_sulcus { get; set; }
        [DisplayName("Medial IP Ramus")]
        [Required]
        public int Medial_IP_ramus { get; set; }
        [DisplayName("Dorsal Pitting")]
        [Required]
        public int Dorsal_pitting { get; set; }
        [DisplayName("Foreman Magnum")]
        public float Foreman_magnum { get; set; }
        [DisplayName("Femur Head")]
        public float femur_head { get; set; }
        [DisplayName("Humerus Head")]
        public float humerus_head { get; set; }
        [DisplayName("Osteophytosis")]
        public string osteophytosis { get; set; }
        [DisplayName("Pubic Symphysis")]
        public string public_symphysis { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        [DisplayName("Bone Length")]
        public int Bone_length { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        [DisplayName("Medial Clavicle")]
        public float Medial_clavicle { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        [DisplayName("Iliac Crest")]
        public float Iliac_crest { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        [DisplayName("Femur Diameter")]
        public float Femur_diameter { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        [DisplayName("Humerus")]
        public float Humerus { get; set; }
        [DisplayName("Femur Length")]
        public float Femur_length { get; set; }
        [DisplayName("Humerus Length")]
        public float Humerus_length { get; set; }
        [DisplayName("Tibia Length")]
        public float Tibia_length { get; set; }
        [DisplayName("Robust")]
        [Required]
        public int Robust { get; set; }
        [DisplayName("Superorbital")]
        [Required]
        public int Superorbital { get; set; }
        [DisplayName("Orbit Edge")]
        [Required]
        public int Orbit_edge { get; set; }
        [DisplayName("Parietal Bossing")]
        [Required]
        public int Parietal_bossing { get; set; }
        [DisplayName("Gonian")]
        [Required]
        public int Gonian { get; set; }
        [DisplayName("Nuchal Crest")]
        [Required]
        public int Nuchal_crest { get; set; }
        [DisplayName("Zygomatic Crest")]
        [Required]
        public int Zygomatic_crest { get; set; }
        [DisplayName("Cranial Suture")]
        public string Cranial_suture { get; set; }
        [DisplayName("Maximum Cranial Length")]
        [Required]
        public float Maxium_cranial_length { get; set; }
        [DisplayName("Maximum Cranial Breadth")]
        [Required]
        public float Maximum_cranial_breadth { get; set; }
        [DisplayName("Basion Bregma Height")]
        [Required]
        public float Basion_bregma_height { get; set; }
        [DisplayName("Basion Nasion")]
        [Required]
        public float Basion_nasion { get; set; }
        [DisplayName("Basion Prosthion Length")]
        [Required]
        public float Basion_prosthion_length { get; set; }
        [DisplayName("Bizygomatic Diameter")]
        [Required]
        public float Bizygomatic_diameter { get; set; }
        [DisplayName("Nasion Prosthion")]
        [Required]
        public float Nasion_prosthion { get; set; }
        [DisplayName("Maximum Nasal Breadth")]
        [Required]
        public float Maximum_nasal_breadth { get; set; }
        [DisplayName("Interorbital Breadth")]
        [Required]
        public float Interorbital_breadth { get; set; }
        [DisplayName("Tooth Attrition")]
        public string Tooth_attrition { get; set; }
        [DisplayName("Tooth Eruption")]
        public string Tooth_eruption { get; set; }
        [DisplayName("Pathology Anomalies")]
        public string Pathology_anomalies { get; set; }
        [DisplayName("Epiphyseal Union")]
        public bool Epiphyseal_union { get; set; }
        [DisplayName("Date on Skull")]
        public DateTime Date_on_skull { get; set; }
        [DisplayName("Field Book")]
        public string Field_book { get; set; }
        [DisplayName("Field Book Page Number")]
        public string Field_book_page_number { get; set; }
        [DisplayName("Initials of Data Entry Expert")]
        public string Initials_of_data_entry_expert { get; set; }
        [DisplayName("Initials of Data Entry Checker")]
        public string Initials_of_data_entry_checker { get; set; }
        [DisplayName("BYU Sample")]
        [Required]
        public bool BYU_sample { get; set; }
        [DisplayName("Body Analysis")]
        public int Body_analysis { get; set; }
        [DisplayName("Skull at Magazine")]
        [Required]
        public bool Skull_at_Magazine { get; set; }
        [DisplayName("Postcrania at Magazine")]
        [Required]
        public bool Postcrania_at_magazine { get; set; }
        [DisplayName("To Be Confirmed")]
        [Required]
        public bool To_be_Comfirmed { get; set; }
        [DisplayName("Skull Trauma")]
        [Required]
        public bool Skull_Trauma { get; set; }
        [DisplayName("Postcrania Trauma")]
        [Required]
        public bool Postcrania_trauma { get; set; }
        [DisplayName("Cribra Orbitala")]
        [Required]
        public bool Cribra_Orbitala { get; set; }
        [DisplayName("Porotic Hyperostosis")]
        [Required]
        public bool Porotic_Hyperostosis { get; set; }
        [DisplayName("Porotic Hyperostosis Locations")]
        [Required]
        public string Porotic_Hyperostosis_Locations { get; set; }
        [DisplayName("Metopic Suture")]
        [Required]
        public bool Metopic_suture { get; set; }
        [DisplayName("Button Osteoma")]
        [Required]
        public bool Button_osteoma { get; set; }
        [DisplayName("Osteology Unknown Comment")]
        public string Osteology_unknown_comment { get; set; }
        [DisplayName("Temporal Mandibular Joint Osteoarthritis")]
        [Required]
        //There were no data inputs for this feature, so we had to guess.
        //Our educated assumption was that, like most of the similar features
        //in the data set, it was a bool
        public bool Temporal_mandibular_joint_osteoarthritiis { get; set; }
        [DisplayName("Length of Burial")]
        public float Length_of_burial { get; set; }
        [DisplayName("Burial Goods")]
        [Required]
        public string Goods { get; set; }
        [DisplayName("Face Bundle")]
        public string Face_Bundle { get; set; }
        [DisplayName("Osteology Notes")]
        public string Osteology_Notes { get; set; }
        [DisplayName("Burial Icon 1")]
        [Required]
        public string Burial_icon1 { get; set; }
        [DisplayName("Burial Icon 2")]
        [Required]
        public string Burial_Icon2 { get; set; }
        [DisplayName("Image File")]

        //This is for images of burials in general
        [ForeignKey("FileOnFileSystemModel")]
        public int? ImgOnSystem { get; set; }
        [DisplayName("Notebook Input")]
        //This is for scans of the field notes
        [ForeignKey("FileOnFileSystemModel")]
        public int? NoteBookOnSystem { get; set; }
        [DisplayName("Bone Book Input")]
        //This is the scans of bone books
        [ForeignKey("FileOnFileSystemModel")]
        public int? BoneBookOnSystem { get; set; }
    }
}
