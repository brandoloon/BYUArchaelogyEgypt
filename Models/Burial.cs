using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaelogyEgypt.Models
{
    public class Burial
    {
        [Key]
        public int BurialID { get; set; }
        [Required]
        [ForeignKey("Location")]
        public Location Location { get; set; }
        [Required]
        public int Burial_depth { get; set; }
        [Required]
        public string South_to_head { get; set; }
        [Required]
        public string South_to_feet { get; set; }
        [Required]
        public string East_to_head { get; set; }
        [Required]
        public string East_to_feet { get; set; }
        public int Length_of_remains { get; set; }
        public int Sample_number { get; set; }
        [Required]
        public float GE_function { get; set; }
        public string Burial_situation { get; set; }
        public string Artifacts_description { get; set; }
        [Required]
        [ForeignKey("Sex")]
        public Sex Sex { get; set; }
        [Required]
        [ForeignKey("Sex")]
        public Sex Gender_GE { get; set; }
        [Required]
        [ForeignKey("HairColor")]
        public string Hair_color { get; set; }
        [Required]
        [ForeignKey("BurialWrapping")]
        public BurialWrapping Burial_wrapping { get; set; }
        public string Preservation { get; set; }
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
        public bool Artifact_found { get; set; }
        [Required]
        [ForeignKey("AgeAtDeath")]
        public AgeAtDeath Age_bracket_at_death { get; set; }
        public int Estimated_age { get; set; }
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
        public int Ventral_arc { get; set;}
        [Required]
        public int Subpubic_angle { get; set;}
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
    }
}
