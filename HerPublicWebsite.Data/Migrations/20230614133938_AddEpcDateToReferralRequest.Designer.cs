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
    [Migration("20230614133938_AddEpcDateToReferralRequest")]
    partial class AddEpcDateToReferralRequest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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

                    b.Property<DateTime?>("EpcLodgementDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("EpcRating")
                        .HasColumnType("integer");

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

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.ToTable("ReferralRequests");
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
#pragma warning restore 612, 618
        }
    }
}
