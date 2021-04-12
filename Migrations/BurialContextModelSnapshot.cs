﻿// <auto-generated />
using System;
using BYUArchaeologyEgypt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BYUArchaeologyEgypt.Migrations
{
    [DbContext(typeof(BurialContext))]
    partial class BurialContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BYUArchaeologyEgypt.Areas.Identity.Data.BYUArchaeologyEgyptUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BYUArchaeologyEgypt.Models.BiologicalSample", b =>
                {
                    b.Property<int>("SampleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BagNum")
                        .HasColumnType("int");

                    b.Property<int>("Burial")
                        .HasColumnType("int");

                    b.Property<int>("C14CalendarDate")
                        .HasColumnType("int");

                    b.Property<int>("C14_2017")
                        .HasColumnType("int");

                    b.Property<int>("CalendarDateAVG")
                        .HasColumnType("int");

                    b.Property<int>("CalendarDateMAX")
                        .HasColumnType("int");

                    b.Property<int>("CalendarDateMIN")
                        .HasColumnType("int");

                    b.Property<int>("CalendarDateSPAN")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClusterNumber")
                        .HasColumnType("int");

                    b.Property<int>("ConventionalC14Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateFound")
                        .HasColumnType("datetime2");

                    b.Property<int>("Foci")
                        .HasColumnType("int");

                    b.Property<string>("Initials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PreviouslySampled")
                        .HasColumnType("bit");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RackNum")
                        .HasColumnType("int");

                    b.Property<float>("Size")
                        .HasColumnType("real");

                    b.HasKey("SampleId");

                    b.ToTable("BiologicalSamples");
                });

            modelBuilder.Entity("BYUArchaeologyEgypt.Models.Burial", b =>
                {
                    b.Property<int>("BurialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age_Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age_bracket_at_death")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area_hill_burials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Artifact_found")
                        .HasColumnType("bit");

                    b.Property<string>("Artifacts_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BYU_sample")
                        .HasColumnType("bit");

                    b.Property<string>("Basilar_suture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Basion_bregma_height")
                        .HasColumnType("real");

                    b.Property<float>("Basion_nasion")
                        .HasColumnType("real");

                    b.Property<float>("Basion_prosthion_length")
                        .HasColumnType("real");

                    b.Property<float>("Bizygomatic_diameter")
                        .HasColumnType("real");

                    b.Property<int>("Body_analysis")
                        .HasColumnType("int");

                    b.Property<int?>("BoneBookOnSystem")
                        .HasColumnType("int");

                    b.Property<int>("Bone_length")
                        .HasColumnType("int");

                    b.Property<bool>("Bone_taken")
                        .HasColumnType("bit");

                    b.Property<string>("Burial_Icon2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Burial_depth")
                        .HasColumnType("int");

                    b.Property<string>("Burial_icon1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Burial_situation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Burial_wrapping")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Button_osteoma")
                        .HasColumnType("bit");

                    b.Property<string>("Cranial_suture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cribra_Orbitala")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date_on_skull")
                        .HasColumnType("datetime2");

                    b.Property<int>("Day_found")
                        .HasColumnType("int");

                    b.Property<string>("Description_of_taken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dorsal_pitting")
                        .HasColumnType("int");

                    b.Property<bool>("Epiphyseal_union")
                        .HasColumnType("bit");

                    b.Property<int>("Estimate_living_stature")
                        .HasColumnType("int");

                    b.Property<int>("Estimated_age_at_death")
                        .HasColumnType("int");

                    b.Property<string>("Face_Bundle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Femur_diameter")
                        .HasColumnType("real");

                    b.Property<float>("Femur_length")
                        .HasColumnType("real");

                    b.Property<string>("Field_book")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field_book_page_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Foreman_magnum")
                        .HasColumnType("real");

                    b.Property<float>("GE_function")
                        .HasColumnType("real");

                    b.Property<int>("Gonian")
                        .HasColumnType("int");

                    b.Property<string>("Goods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hair_color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hair_taken")
                        .HasColumnType("bit");

                    b.Property<string>("Head_direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Humerus")
                        .HasColumnType("real");

                    b.Property<float>("Humerus_length")
                        .HasColumnType("real");

                    b.Property<float>("Iliac_crest")
                        .HasColumnType("real");

                    b.Property<int?>("ImgOnSystem")
                        .HasColumnType("int");

                    b.Property<string>("Initials_of_data_entry_checker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Initials_of_data_entry_expert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Interorbital_breadth")
                        .HasColumnType("real");

                    b.Property<float>("Length_of_burial")
                        .HasColumnType("real");

                    b.Property<int>("Length_of_remains")
                        .HasColumnType("int");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<float>("Maximum_cranial_breadth")
                        .HasColumnType("real");

                    b.Property<float>("Maximum_nasal_breadth")
                        .HasColumnType("real");

                    b.Property<float>("Maxium_cranial_length")
                        .HasColumnType("real");

                    b.Property<int>("Medial_IP_ramus")
                        .HasColumnType("int");

                    b.Property<float>("Medial_clavicle")
                        .HasColumnType("real");

                    b.Property<bool>("Metopic_suture")
                        .HasColumnType("bit");

                    b.Property<int>("Month_found")
                        .HasColumnType("int");

                    b.Property<float>("Nasion_prosthion")
                        .HasColumnType("real");

                    b.Property<int?>("NoteBookOnSystem")
                        .HasColumnType("int");

                    b.Property<int>("Nuchal_crest")
                        .HasColumnType("int");

                    b.Property<int>("Orbit_edge")
                        .HasColumnType("int");

                    b.Property<string>("Osteology_Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Osteology_unknown_comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parietal_bossing")
                        .HasColumnType("int");

                    b.Property<string>("Pathology_anomalies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Porotic_Hyperostosis")
                        .HasColumnType("bit");

                    b.Property<string>("Porotic_Hyperostosis_Locations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Postcrania_at_magazine")
                        .HasColumnType("bit");

                    b.Property<bool>("Postcrania_trauma")
                        .HasColumnType("bit");

                    b.Property<int>("Preaur_sulcus")
                        .HasColumnType("int");

                    b.Property<string>("Preservation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Public_bone")
                        .HasColumnType("int");

                    b.Property<int>("Robust")
                        .HasColumnType("int");

                    b.Property<int>("Sample_number")
                        .HasColumnType("int");

                    b.Property<int>("Sciatic_notch")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex_Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Skull_Trauma")
                        .HasColumnType("bit");

                    b.Property<bool>("Skull_at_Magazine")
                        .HasColumnType("bit");

                    b.Property<bool>("Soft_tissue")
                        .HasColumnType("bit");

                    b.Property<float>("South_to_feet")
                        .HasColumnType("real");

                    b.Property<float>("South_to_head")
                        .HasColumnType("real");

                    b.Property<int>("Subpubic_angle")
                        .HasColumnType("int");

                    b.Property<int>("Superorbital")
                        .HasColumnType("int");

                    b.Property<bool>("Temporal_mandibular_joint_osteoarthritiis")
                        .HasColumnType("bit");

                    b.Property<bool>("Texile_taken")
                        .HasColumnType("bit");

                    b.Property<float>("Tibia_length")
                        .HasColumnType("real");

                    b.Property<bool>("To_be_Comfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Tomb_number")
                        .HasColumnType("int");

                    b.Property<string>("Tooth_attrition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tooth_eruption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Tooth_taken")
                        .HasColumnType("bit");

                    b.Property<int>("Ventral_arc")
                        .HasColumnType("int");

                    b.Property<float>("West_to_feet")
                        .HasColumnType("real");

                    b.Property<float>("West_to_head")
                        .HasColumnType("real");

                    b.Property<int>("Year_found")
                        .HasColumnType("int");

                    b.Property<int>("Zygomatic_crest")
                        .HasColumnType("int");

                    b.Property<float>("femur_head")
                        .HasColumnType("real");

                    b.Property<float>("humerus_head")
                        .HasColumnType("real");

                    b.Property<string>("osteophytosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("public_symphysis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BurialID");

                    b.ToTable("Burials");
                });

            modelBuilder.Entity("BYUArchaeologyEgypt.Models.FileOnFileSystemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FileOnFileSystemModels");
                });

            modelBuilder.Entity("BYUArchaeologyEgypt.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BurialLocationEW")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BurialLocationNS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighPairEW")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighPairNS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LowPairEW")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LowPairNS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subplot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BYUArchaeologyEgypt.Areas.Identity.Data.BYUArchaeologyEgyptUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BYUArchaeologyEgypt.Areas.Identity.Data.BYUArchaeologyEgyptUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BYUArchaeologyEgypt.Areas.Identity.Data.BYUArchaeologyEgyptUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BYUArchaeologyEgypt.Areas.Identity.Data.BYUArchaeologyEgyptUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
