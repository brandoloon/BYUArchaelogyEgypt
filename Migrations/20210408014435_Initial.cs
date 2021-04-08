using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BYUArchaelogyEgypt.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgesAtDeath",
                columns: table => new
                {
                    AgeCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgesAtDeath", x => x.AgeCode);
                });

            migrationBuilder.CreateTable(
                name: "BurialWrappings",
                columns: table => new
                {
                    BurialWrappingCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurialWrappingDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurialWrappings", x => x.BurialWrappingCode);
                });

            migrationBuilder.CreateTable(
                name: "HairColors",
                columns: table => new
                {
                    HairColorCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HairColorDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairColors", x => x.HairColorCode);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurialLocationNS = table.Column<string>(nullable: false),
                    BurialLocationEW = table.Column<string>(nullable: false),
                    LowPairNS = table.Column<string>(nullable: false),
                    HighPairNS = table.Column<string>(nullable: false),
                    LowPairEW = table.Column<string>(nullable: false),
                    HighPairEW = table.Column<string>(nullable: false),
                    Subplot = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    SexCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SexDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.SexCode);
                });

            migrationBuilder.CreateTable(
                name: "Burials",
                columns: table => new
                {
                    BurialID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tomb_number = table.Column<int>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    Area_hill_burials = table.Column<string>(nullable: false),
                    Burial_depth = table.Column<int>(nullable: false),
                    South_to_head = table.Column<float>(nullable: false),
                    South_to_feet = table.Column<float>(nullable: false),
                    West_to_head = table.Column<float>(nullable: false),
                    West_to_feet = table.Column<float>(nullable: false),
                    Length_of_remains = table.Column<int>(nullable: false),
                    Sample_number = table.Column<int>(nullable: false),
                    Artifact_found = table.Column<bool>(nullable: false),
                    Artifacts_description = table.Column<string>(nullable: true),
                    Hair_taken = table.Column<bool>(nullable: false),
                    Soft_tissue = table.Column<bool>(nullable: false),
                    Bone_taken = table.Column<bool>(nullable: false),
                    Tooth_taken = table.Column<bool>(nullable: false),
                    Texile_taken = table.Column<bool>(nullable: false),
                    Description_of_taken = table.Column<string>(nullable: true),
                    GE_function = table.Column<float>(nullable: false),
                    Burial_situation = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Gender_GE = table.Column<int>(nullable: false),
                    Sex_Method = table.Column<string>(nullable: true),
                    Hair_color = table.Column<string>(nullable: false),
                    BurialWrapping = table.Column<int>(nullable: false),
                    Preservation = table.Column<string>(nullable: true),
                    AgeAtDeath = table.Column<int>(nullable: false),
                    Estimated_age_at_death = table.Column<int>(nullable: false),
                    Age_Method = table.Column<string>(nullable: true),
                    Estimate_living_stature = table.Column<int>(nullable: false),
                    Year_found = table.Column<int>(nullable: false),
                    Month_found = table.Column<int>(nullable: false),
                    Day_found = table.Column<int>(nullable: false),
                    Head_direction = table.Column<string>(nullable: true),
                    Basilar_suture = table.Column<string>(nullable: false),
                    Ventral_arc = table.Column<int>(nullable: false),
                    Subpubic_angle = table.Column<int>(nullable: false),
                    Sciatic_notch = table.Column<int>(nullable: false),
                    Public_bone = table.Column<int>(nullable: false),
                    Preaur_sulcus = table.Column<int>(nullable: false),
                    Medial_IP_ramus = table.Column<int>(nullable: false),
                    Dorsal_pitting = table.Column<int>(nullable: false),
                    Foreman_magnum = table.Column<float>(nullable: false),
                    femur_head = table.Column<float>(nullable: false),
                    humerus_head = table.Column<float>(nullable: false),
                    osteophytosis = table.Column<string>(nullable: true),
                    public_symphysis = table.Column<string>(nullable: true),
                    Bone_length = table.Column<int>(nullable: false),
                    Medial_clavicle = table.Column<float>(nullable: false),
                    Iliac_crest = table.Column<float>(nullable: false),
                    Femur_diameter = table.Column<float>(nullable: false),
                    Humerus = table.Column<float>(nullable: false),
                    Femur_length = table.Column<float>(nullable: false),
                    Humerus_length = table.Column<float>(nullable: false),
                    Tibia_length = table.Column<float>(nullable: false),
                    Robust = table.Column<int>(nullable: false),
                    Superorbital = table.Column<int>(nullable: false),
                    Orbit_edge = table.Column<int>(nullable: false),
                    Parietal_bossing = table.Column<int>(nullable: false),
                    Gonian = table.Column<int>(nullable: false),
                    Nuchal_crest = table.Column<int>(nullable: false),
                    Zygomatic_crest = table.Column<int>(nullable: false),
                    Cranial_suture = table.Column<string>(nullable: true),
                    Maxium_cranial_length = table.Column<float>(nullable: false),
                    Maximum_cranial_breadth = table.Column<float>(nullable: false),
                    Basion_bregma_height = table.Column<float>(nullable: false),
                    Basion_nasion = table.Column<float>(nullable: false),
                    Basion_prosthion_length = table.Column<float>(nullable: false),
                    Bizygomatic_diameter = table.Column<float>(nullable: false),
                    Nasion_prosthion = table.Column<float>(nullable: false),
                    Maximum_nasal_breadth = table.Column<float>(nullable: false),
                    Interorbital_breadth = table.Column<float>(nullable: false),
                    Tooth_attrition = table.Column<string>(nullable: true),
                    Tooth_eruption = table.Column<string>(nullable: true),
                    Pathology_anomalies = table.Column<string>(nullable: true),
                    Epiphyseal_union = table.Column<bool>(nullable: false),
                    Date_on_skull = table.Column<DateTime>(nullable: false),
                    Field_book = table.Column<string>(nullable: true),
                    Field_book_page_number = table.Column<string>(nullable: true),
                    Initials_of_data_entry_expert = table.Column<string>(nullable: true),
                    Initials_of_data_entry_checker = table.Column<string>(nullable: true),
                    BYU_sample = table.Column<bool>(nullable: false),
                    Body_analysis = table.Column<int>(nullable: false),
                    Skull_at_Magazine = table.Column<bool>(nullable: false),
                    Postcrania_at_magazine = table.Column<bool>(nullable: false),
                    To_be_Comfirmed = table.Column<bool>(nullable: false),
                    Skull_Trauma = table.Column<bool>(nullable: false),
                    Postcrania_trauma = table.Column<bool>(nullable: false),
                    Cribra_Orbitala = table.Column<bool>(nullable: false),
                    Porotic_Hyperostosis = table.Column<bool>(nullable: false),
                    Porotic_Hyperostosis_Locations = table.Column<string>(nullable: false),
                    Metopic_suture = table.Column<bool>(nullable: false),
                    Button_osteoma = table.Column<bool>(nullable: false),
                    Osteology_unknown_comment = table.Column<string>(nullable: true),
                    Temporal_mandibular_joint_osteoarthritiis = table.Column<bool>(nullable: false),
                    Length_of_burial = table.Column<float>(nullable: false),
                    Goods = table.Column<string>(nullable: true),
                    Face_Bundle = table.Column<string>(nullable: true),
                    Osteology_Notes = table.Column<string>(nullable: true),
                    Burial_icon1 = table.Column<string>(nullable: false),
                    Burial_Icon2 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burials", x => x.BurialID);
                    table.ForeignKey(
                        name: "FK_Burials_AgesAtDeath_AgeAtDeath",
                        column: x => x.AgeAtDeath,
                        principalTable: "AgesAtDeath",
                        principalColumn: "AgeCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Burials_BurialWrappings_BurialWrapping",
                        column: x => x.BurialWrapping,
                        principalTable: "BurialWrappings",
                        principalColumn: "BurialWrappingCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BiologicalSample",
                columns: table => new
                {
                    SampleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurialID = table.Column<int>(nullable: true),
                    RackNum = table.Column<int>(nullable: false),
                    BagNum = table.Column<int>(nullable: false),
                    ClusterNumber = table.Column<int>(nullable: false),
                    DateFound = table.Column<DateTime>(nullable: false),
                    PreviouslySampled = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiologicalSample", x => x.SampleId);
                    table.ForeignKey(
                        name: "FK_BiologicalSample_Burials_BurialID",
                        column: x => x.BurialID,
                        principalTable: "Burials",
                        principalColumn: "BurialID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiologicalSample_BurialID",
                table: "BiologicalSample",
                column: "BurialID");

            migrationBuilder.CreateIndex(
                name: "IX_Burials_AgeAtDeath",
                table: "Burials",
                column: "AgeAtDeath");

            migrationBuilder.CreateIndex(
                name: "IX_Burials_BurialWrapping",
                table: "Burials",
                column: "BurialWrapping");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiologicalSample");

            migrationBuilder.DropTable(
                name: "HairColors");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropTable(
                name: "Burials");

            migrationBuilder.DropTable(
                name: "AgesAtDeath");

            migrationBuilder.DropTable(
                name: "BurialWrappings");
        }
    }
}
