﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using HerPublicWebsite.Data;

#nullable disable

namespace HerPublicWebsite.Data.Migrations
{
    [DbContext(typeof(HerDbContext))]
    [Migration("20220620125327_AddUpdatesObjectToPropertyData")]
    partial class AddUpdatesObjectToPropertyData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FriendlyName")
                        .HasColumnType("text");

                    b.Property<string>("Xml")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.Epc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .HasColumnType("text");

                    b.Property<string>("Address2")
                        .HasColumnType("text");

                    b.Property<int?>("BungalowType")
                        .HasColumnType("integer");

                    b.Property<int?>("CavityWallsInsulated")
                        .HasColumnType("integer");

                    b.Property<int?>("ConstructionAgeBand")
                        .HasColumnType("integer");

                    b.Property<string>("EpcId")
                        .HasColumnType("text");

                    b.Property<int?>("FlatType")
                        .HasColumnType("integer");

                    b.Property<int?>("FloorConstruction")
                        .HasColumnType("integer");

                    b.Property<int?>("FloorInsulated")
                        .HasColumnType("integer");

                    b.Property<int?>("GlazingType")
                        .HasColumnType("integer");

                    b.Property<int?>("HasHotWaterCylinder")
                        .HasColumnType("integer");

                    b.Property<int?>("HeatingType")
                        .HasColumnType("integer");

                    b.Property<int?>("HouseType")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LodgementDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("OtherHeatingType")
                        .HasColumnType("integer");

                    b.Property<string>("Postcode")
                        .HasColumnType("text");

                    b.Property<int?>("PropertyType")
                        .HasColumnType("integer");

                    b.Property<int?>("RoofConstruction")
                        .HasColumnType("integer");

                    b.Property<int?>("RoofInsulated")
                        .HasColumnType("integer");

                    b.Property<int?>("SolidWallsInsulated")
                        .HasColumnType("integer");

                    b.Property<int?>("WallConstruction")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Epc");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.PropertyData", b =>
                {
                    b.Property<int>("PropertyDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PropertyDataId"));

                    b.Property<int?>("BungalowType")
                        .HasColumnType("integer");

                    b.Property<int?>("CavityWallsInsulated")
                        .HasColumnType("integer");

                    b.Property<int?>("Country")
                        .HasColumnType("integer");

                    b.Property<int?>("EpcId")
                        .HasColumnType("integer");

                    b.Property<int?>("FlatType")
                        .HasColumnType("integer");

                    b.Property<int?>("FloorConstruction")
                        .HasColumnType("integer");

                    b.Property<int?>("FloorInsulated")
                        .HasColumnType("integer");

                    b.Property<int?>("GlazingType")
                        .HasColumnType("integer");

                    b.Property<int?>("HasHotWaterCylinder")
                        .HasColumnType("integer");

                    b.Property<int?>("HasOutdoorSpace")
                        .HasColumnType("integer");

                    b.Property<int?>("HeatingPattern")
                        .HasColumnType("integer");

                    b.Property<int?>("HeatingType")
                        .HasColumnType("integer");

                    b.Property<int?>("HoursOfHeatingEvening")
                        .HasColumnType("integer");

                    b.Property<int?>("HoursOfHeatingMorning")
                        .HasColumnType("integer");

                    b.Property<string>("HouseNameOrNumber")
                        .HasColumnType("text");

                    b.Property<int?>("HouseType")
                        .HasColumnType("integer");

                    b.Property<int?>("LoftAccess")
                        .HasColumnType("integer");

                    b.Property<int?>("LoftSpace")
                        .HasColumnType("integer");

                    b.Property<int?>("NumberOfOccupants")
                        .HasColumnType("integer");

                    b.Property<int?>("OtherHeatingType")
                        .HasColumnType("integer");

                    b.Property<int?>("OwnershipStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Postcode")
                        .HasColumnType("text");

                    b.Property<int?>("PropertyType")
                        .HasColumnType("integer");

                    b.Property<string>("Reference")
                        .HasColumnType("text");

                    b.Property<int?>("RoofConstruction")
                        .HasColumnType("integer");

                    b.Property<int?>("RoofInsulated")
                        .HasColumnType("integer");

                    b.Property<int?>("SolidWallsInsulated")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Temperature")
                        .HasColumnType("numeric");

                    b.Property<int?>("WallConstruction")
                        .HasColumnType("integer");

                    b.Property<int?>("YearBuilt")
                        .HasColumnType("integer");

                    b.HasKey("PropertyDataId");

                    b.HasIndex("EpcId");

                    b.HasIndex("Reference")
                        .IsUnique();

                    b.ToTable("PropertyData");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.PropertyRecommendation", b =>
                {
                    b.Property<int>("PropertyRecommendationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PropertyRecommendationId"));

                    b.Property<int>("Key")
                        .HasColumnType("integer");

                    b.Property<int>("Lifetime")
                        .HasColumnType("integer");

                    b.Property<int>("LifetimeSaving")
                        .HasColumnType("integer");

                    b.Property<int>("MaxInstallCost")
                        .HasColumnType("integer");

                    b.Property<int>("MinInstallCost")
                        .HasColumnType("integer");

                    b.Property<int>("PropertyDataId")
                        .HasColumnType("integer");

                    b.Property<int?>("RecommendationAction")
                        .HasColumnType("integer");

                    b.Property<int>("Saving")
                        .HasColumnType("integer");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("PropertyRecommendationId");

                    b.HasIndex("PropertyDataId");

                    b.ToTable("PropertyRecommendations");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.PropertyData", b =>
                {
                    b.HasOne("HerPublicWebsite.BusinessLogic.Models.Epc", "Epc")
                        .WithMany()
                        .HasForeignKey("EpcId");

                    b.Navigation("Epc");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.PropertyRecommendation", b =>
                {
                    b.HasOne("HerPublicWebsite.BusinessLogic.Models.PropertyData", "PropertyData")
                        .WithMany("PropertyRecommendations")
                        .HasForeignKey("PropertyDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropertyData");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.PropertyData", b =>
                {
                    b.Navigation("PropertyRecommendations");
                });
#pragma warning restore 612, 618
        }
    }
}
