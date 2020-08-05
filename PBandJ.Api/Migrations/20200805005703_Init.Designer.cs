﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PBandJ.Api.Entities;
using PBandJ.Api.Enums;
using System;

namespace PBandJ.Api.Migrations
{
    [DbContext(typeof(HandRangeContext))]
    [Migration("20200805005703_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PBandJ.Api.Entities.HandRange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hands");

                    b.Property<int>("PositionId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PositionId")
                        .IsUnique();

                    b.ToTable("HandRanges");
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<int>("PositionEnum");

                    b.Property<int>("SituationId");

                    b.HasKey("Id");

                    b.HasIndex("SituationId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Scenario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Scenarios");
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Situation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<int>("ScenarioId");

                    b.HasKey("Id");

                    b.HasIndex("ScenarioId");

                    b.ToTable("Situation");
                });

            modelBuilder.Entity("PBandJ.Api.Entities.HandRange", b =>
                {
                    b.HasOne("PBandJ.Api.Entities.Position")
                        .WithOne("HandRange")
                        .HasForeignKey("PBandJ.Api.Entities.HandRange", "PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Position", b =>
                {
                    b.HasOne("PBandJ.Api.Entities.Situation")
                        .WithMany("HerosPositions")
                        .HasForeignKey("SituationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Situation", b =>
                {
                    b.HasOne("PBandJ.Api.Entities.Scenario")
                        .WithMany("Situations")
                        .HasForeignKey("ScenarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
