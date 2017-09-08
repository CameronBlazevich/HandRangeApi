﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PBandJ.Api.Entities;
using System;

namespace PBandJ.Api.Migrations
{
    [DbContext(typeof(HandRangeContext))]
    [Migration("20170907042732_PBandJInitialMigration")]
    partial class PBandJInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PBandJ.Api.Entities.HandRange", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("Position");

                    b.Property<string>("Hands");

                    b.HasKey("UserId", "Position");

                    b.ToTable("HandRanges");
                });
#pragma warning restore 612, 618
        }
    }
}
