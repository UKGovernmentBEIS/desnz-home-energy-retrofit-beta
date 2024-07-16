﻿// <auto-generated />
using System;
using HerPublicWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HerPublicWebsite.Data.Migrations
{
    [DbContext(typeof(HerDbContext))]
    [Migration("20240716092900_ChangeSessionsTimestampToIncludeTimeZone")]
    partial class ChangeSessionsTimestampToIncludeTimeZone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.AnonymisedReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EpcLodgementDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("EpcRating")
                        .HasColumnType("integer");

                    b.Property<int>("HasGasBoiler")
                        .HasColumnType("integer");

                    b.Property<int>("IncomeBand")
                        .HasColumnType("integer");

                    b.Property<bool>("IsEligible")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLsoaProperty")
                        .HasColumnType("boolean");

                    b.Property<int>("OwnershipStatus")
                        .HasColumnType("integer");

                    b.Property<string>("PostcodeFirstHalf")
                        .HasColumnType("text");

                    b.Property<DateTime?>("SubmissionDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.ToTable("AnonymisedReports");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.NotificationDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("FutureSchemeNotificationConsent")
                        .HasColumnType("boolean");

                    b.Property<string>("FutureSchemeNotificationEmail")
                        .HasColumnType("text");

                    b.Property<int?>("ReferralRequestId")
                        .HasColumnType("integer");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.HasIndex("ReferralRequestId");

                    b.ToTable("NotificationDetails");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.PerReferralReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressCounty")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("text");

                    b.Property<string>("AddressPostcode")
                        .HasColumnType("text");

                    b.Property<string>("AddressTown")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ApplicationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ReferralCode")
                        .HasColumnType("text");

                    b.Property<string>("Uprn")
                        .HasColumnType("text");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.ToTable("PerReferralReports");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.ReferralRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressCounty")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("text");

                    b.Property<string>("AddressPostcode")
                        .HasColumnType("text");

                    b.Property<string>("AddressTown")
                        .HasColumnType("text");

                    b.Property<string>("ContactEmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("ContactTelephone")
                        .HasColumnType("text");

                    b.Property<string>("CustodianCode")
                        .HasColumnType("text");

                    b.Property<int?>("EpcConfirmation")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("EpcLodgementDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("EpcRating")
                        .HasColumnType("integer");

                    b.Property<bool>("FollowUpEmailSent")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<int>("HasGasBoiler")
                        .HasColumnType("integer");

                    b.Property<int>("IncomeBand")
                        .HasColumnType("integer");

                    b.Property<bool>("IsLsoaProperty")
                        .HasColumnType("boolean");

                    b.Property<string>("ReferralCode")
                        .HasColumnType("text");

                    b.Property<bool>("ReferralWrittenToCsv")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Uprn")
                        .HasColumnType("text");

                    b.Property<bool>("WasSubmittedToPendingLocalAuthority")
                        .HasColumnType("boolean");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.ToTable("ReferralRequests");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.ReferralRequestFollowUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateOfFollowUpResponse")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ReferralRequestId")
                        .HasColumnType("integer");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<bool?>("WasFollowedUp")
                        .HasColumnType("boolean");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.HasIndex("ReferralRequestId")
                        .IsUnique();

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("ReferralRequestFollowUps");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

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

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.NotificationDetails", b =>
                {
                    b.HasOne("HerPublicWebsite.BusinessLogic.Models.ReferralRequest", "ReferralRequest")
                        .WithMany()
                        .HasForeignKey("ReferralRequestId");

                    b.Navigation("ReferralRequest");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.ReferralRequestFollowUp", b =>
                {
                    b.HasOne("HerPublicWebsite.BusinessLogic.Models.ReferralRequest", "ReferralRequest")
                        .WithOne("FollowUp")
                        .HasForeignKey("HerPublicWebsite.BusinessLogic.Models.ReferralRequestFollowUp", "ReferralRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReferralRequest");
                });

            modelBuilder.Entity("HerPublicWebsite.BusinessLogic.Models.ReferralRequest", b =>
                {
                    b.Navigation("FollowUp");
                });
#pragma warning restore 612, 618
        }
    }
}
