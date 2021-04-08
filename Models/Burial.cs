using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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
        public int Tomb_number { get; set; }
        [ForeignKey("Location")]
        public int Location { get; set; }
        [Required]
        //We made this a string in the case that a researcher enters a character
        //We felt that it was a likely occurence. Moreover, no mathmatical operations
        //will be run on these values
        public string Area_hill_burials { get; set; }
        public int Burial_depth { get; set; }
        [Required]
        public float South_to_head { get; set; }
        [Required]
        public float South_to_feet { get; set; }
        [Required]
        public float West_to_head { get; set; }
        [Required]
        public float West_to_feet { get; set; }
        public int Length_of_remains { get; set; }
        public int Sample_number { get; set; }
        public List<BiologicalSample> BiologicalSamples { get; set; }
        [Required]
        public bool Artifact_found { get; set; }
        public string Artifacts_description { get; set; }
        [Required]
        public bool Hair_taken { get; set; }
        [Required]
        public bool Soft_tissue { get; set; }
        [Required]
        public bool Bone_taken { get; set; }
        [Required]
        public bool Tooth_taken { get; set; }
        [Required]
        public bool Texile_taken { get; set; }
        public string Description_of_taken { get; set; }
        [Required]
        public float GE_function { get; set; }
        public string Burial_situation { get; set; }
        [Required]
        [ForeignKey("Sex")]
        public int Sex { get; set; }
        [Required]
        [ForeignKey("Sex")]
        public int Gender_GE { get; set; }
        public string Sex_Method { get; set; }
        [Required]
        [ForeignKey("HairColor")]
        public int Hair_color { get; set; }
        [Required]
        [ForeignKey("BurialWrapping")]
        public int Burial_wrapping { get; set; }
        public string Preservation { get; set; }
        [Required]
        [ForeignKey("AgeAtDeath")]
        public int Age_bracket_at_death { get; set; }
        public int Estimated_age_at_death { get; set; }
        public string Age_Method { get; set; }
        public int Estimate_living_stature { get; set; }
        [Required]
        public int Year_found { get; set; }
        [Required]
        public int Month_found { get; set; }
        [Required]
        public int Day_found { get; set; }
        public string Head_direction { get; set; }
        [Required]
        public string Basilar_suture { get; set; }
        [Required]
        public int Ventral_arc { get; set; }
        [Required]
        public int Subpubic_angle { get; set; }
        [Required]
        public int Sciatic_notch { get; set; }
        [Required]
        public int Public_bone { get; set; }
        [Required]
        public int Preaur_sulcus { get; set; }
        [Required]
        public int Medial_IP_ramus { get; set; }
        [Required]
        public int Dorsal_pitting { get; set; }
        public float Foreman_magnum { get; set; }
        public float femur_head { get; set; }
        public float humerus_head { get; set; }
        public string osteophytosis { get; set; }
        public string public_symphysis { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        public int Bone_length { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        public float Medial_clavicle { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        public float Iliac_crest { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        public float Femur_diameter { get; set; }
        //There were not data entries in the sample data for this feature, so we had to guess on the data type
        public float Humerus { get; set; }
        public float Femur_length { get; set; }
        public float Humerus_length { get; set; }
        public float Tibia_length { get; set; }
        [Required]
        public int Robust { get; set; }
        [Required]
        public int Superorbital { get; set; }
        [Required]
        public int Orbit_edge { get; set; }
        [Required]
        public int Parietal_bossing { get; set; }
        [Required]
        public int Gonian { get; set; }
        [Required]
        public int Nuchal_crest { get; set; }
        [Required]
        public int Zygomatic_crest { get; set; }
        public string Cranial_suture { get; set; }
        [Required]
        public float Maxium_cranial_length { get; set; }
        [Required]
        public float Maximum_cranial_breadth { get; set; }
        [Required]
        public float Basion_bregma_height { get; set; }
        [Required]
        public float Basion_nasion { get; set; }
        [Required]
        public float Basion_prosthion_length { get; set; }
        [Required]
        public float Bizygomatic_diameter { get; set; }
        [Required]
        public float Nasion_prosthion { get; set; }
        [Required]
        public float Maximum_nasal_breadth { get; set; }
        [Required]
        public float Interorbital_breadth { get; set; }
        public string Tooth_attrition { get; set; }
        public string Tooth_eruption { get; set; }
        public string Pathology_anomalies { get; set; }
        public bool Epiphyseal_union { get; set; }
        public DateTime Date_on_skull { get; set; }
        public string Field_book { get; set; }
        public string Field_book_page_number { get; set; }
        public string Initials_of_data_entry_expert { get; set; }
        public string Initials_of_data_entry_checker { get; set; }
        [Required]
        public bool BYU_sample { get; set; }
        public int Body_analysis { get; set; }
        [Required]
        public bool Skull_at_Magazine { get; set; }
        [Required]
        public bool Postcrania_at_magazine { get; set; }
        [Required]
        public bool To_be_Comfirmed { get; set; }
        [Required]
        public bool Skull_Trauma { get; set; }
        [Required]
        public bool Postcrania_trauma { get; set; }
        [Required]
        public bool Cribra_Orbitala { get; set; }
        [Required]
        public bool Porotic_Hyperostosis { get; set; }
        [Required]
        public string Porotic_Hyperostosis_Locations { get; set; }
        [Required]
        public bool Metopic_suture { get; set; }
        [Required]
        public bool Button_osteoma { get; set; }
        public string Osteology_unknown_comment { get; set; }
        [Required]
        //There were no data inputs for this feature, so we had to guess.
        //Our educated assumption was that, like most of the similar features
        //in the data set, it was a bool
        public bool Temporal_mandibular_joint_osteoarthritiis { get; set; }
        public float Length_of_burial { get; set; }
        public string Goods { get; set; }
        public string Face_Bundle { get; set; }
        public string Osteology_Notes { get; set; }
        [Required]
        public string Burial_icon1 { get; set; }
        [Required]
        public string Burial_Icon2 { get; set; }
        //This is for images of burials in general
        public List<FileOnFileSystemModel> ImgOnSystem { get; set; } = new List<FileOnFileSystemModel>();
        public List<FileOnDatabaseModel> ImgOnDatabase { get; set; } = new List<FileOnDatabaseModel>();
        //This is for scans of the field notes
        public List<FileOnFileSystemModel> NoteBookOnSystem { get; set; } = new List<FileOnFileSystemModel>();
        public List<FileOnDatabaseModel> NoteBookOnDatabase { get; set; } = new List<FileOnDatabaseModel>();
        //This is the scans of bone books
        public List<FileOnFileSystemModel> BoneBookOnSystem { get; set; } = new List<FileOnFileSystemModel>();
        public List<FileOnDatabaseModel> BoneBookOnDatabase { get; set; } = new List<FileOnDatabaseModel>();
    }
}
