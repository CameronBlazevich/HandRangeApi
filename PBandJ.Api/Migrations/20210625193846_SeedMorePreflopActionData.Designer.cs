﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBandJ.Api.Entities;

namespace PBandJ.Api.Migrations
{
    [DbContext(typeof(HandRangeContext))]
    [Migration("20210625193846_SeedMorePreflopActionData")]
    partial class SeedMorePreflopActionData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.7.20365.15");

            modelBuilder.Entity("PBandJ.Api.Entities.HandRange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Hands")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PositionId")
                        .IsUnique();

                    b.ToTable("HandRanges");
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Key")
                        .HasColumnType("int");

                    b.Property<int>("SituationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SituationId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayName = "UTG",
                            Key = 3,
                            SituationId = 1
                        },
                        new
                        {
                            Id = 2,
                            DisplayName = "HJ",
                            Key = 4,
                            SituationId = 1
                        },
                        new
                        {
                            Id = 3,
                            DisplayName = "CO",
                            Key = 5,
                            SituationId = 1
                        },
                        new
                        {
                            Id = 4,
                            DisplayName = "BTN",
                            Key = 6,
                            SituationId = 1
                        },
                        new
                        {
                            Id = 5,
                            DisplayName = "SB",
                            Key = 1,
                            SituationId = 1
                        },
                        new
                        {
                            Id = 6,
                            DisplayName = "HJ",
                            Key = 4,
                            SituationId = 2
                        },
                        new
                        {
                            Id = 7,
                            DisplayName = "CO",
                            Key = 5,
                            SituationId = 2
                        },
                        new
                        {
                            Id = 8,
                            DisplayName = "BTN",
                            Key = 6,
                            SituationId = 2
                        },
                        new
                        {
                            Id = 9,
                            DisplayName = "SB",
                            Key = 1,
                            SituationId = 2
                        },
                        new
                        {
                            Id = 10,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 2
                        },
                        new
                        {
                            Id = 11,
                            DisplayName = "CO",
                            Key = 5,
                            SituationId = 3
                        },
                        new
                        {
                            Id = 12,
                            DisplayName = "BTN",
                            Key = 6,
                            SituationId = 3
                        },
                        new
                        {
                            Id = 13,
                            DisplayName = "SB",
                            Key = 1,
                            SituationId = 3
                        },
                        new
                        {
                            Id = 14,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 3
                        },
                        new
                        {
                            Id = 15,
                            DisplayName = "BTN",
                            Key = 6,
                            SituationId = 4
                        },
                        new
                        {
                            Id = 16,
                            DisplayName = "SB",
                            Key = 1,
                            SituationId = 4
                        },
                        new
                        {
                            Id = 17,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 4
                        },
                        new
                        {
                            Id = 18,
                            DisplayName = "SB",
                            Key = 1,
                            SituationId = 5
                        },
                        new
                        {
                            Id = 19,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 5
                        },
                        new
                        {
                            Id = 20,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 6
                        },
                        new
                        {
                            Id = 21,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 7
                        },
                        new
                        {
                            Id = 22,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 8
                        },
                        new
                        {
                            Id = 23,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 9
                        },
                        new
                        {
                            Id = 24,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 10
                        },
                        new
                        {
                            Id = 25,
                            DisplayName = "BB",
                            Key = 2,
                            SituationId = 11
                        },
                        new
                        {
                            Id = 26,
                            DisplayName = "SB",
                            Key = 1,
                            SituationId = 12
                        },
                        new
                        {
                            Id = 27,
                            DisplayName = "BTN",
                            Key = 6,
                            SituationId = 12
                        },
                        new
                        {
                            Id = 28,
                            DisplayName = "CO",
                            Key = 5,
                            SituationId = 12
                        },
                        new
                        {
                            Id = 29,
                            DisplayName = "HJ",
                            Key = 4,
                            SituationId = 12
                        },
                        new
                        {
                            Id = 30,
                            DisplayName = "UTG",
                            Key = 3,
                            SituationId = 12
                        },
                        new
                        {
                            Id = 31,
                            DisplayName = "BTN",
                            Key = 6,
                            SituationId = 13
                        },
                        new
                        {
                            Id = 32,
                            DisplayName = "CO",
                            Key = 5,
                            SituationId = 13
                        },
                        new
                        {
                            Id = 33,
                            DisplayName = "HJ",
                            Key = 4,
                            SituationId = 13
                        },
                        new
                        {
                            Id = 34,
                            DisplayName = "UTG",
                            Key = 3,
                            SituationId = 13
                        },
                        new
                        {
                            Id = 35,
                            DisplayName = "CO",
                            Key = 5,
                            SituationId = 14
                        },
                        new
                        {
                            Id = 36,
                            DisplayName = "HJ",
                            Key = 4,
                            SituationId = 14
                        },
                        new
                        {
                            Id = 37,
                            DisplayName = "UTG",
                            Key = 3,
                            SituationId = 14
                        },
                        new
                        {
                            Id = 38,
                            DisplayName = "HJ",
                            Key = 4,
                            SituationId = 15
                        },
                        new
                        {
                            Id = 39,
                            DisplayName = "UTG",
                            Key = 3,
                            SituationId = 15
                        },
                        new
                        {
                            Id = 40,
                            DisplayName = "UTG",
                            Key = 3,
                            SituationId = 16
                        });
                });

            modelBuilder.Entity("PBandJ.Api.Entities.PreflopAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<int>("ActorsPosition")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("PreflopAction");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 6
                        },
                        new
                        {
                            Id = 2,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 7
                        },
                        new
                        {
                            Id = 3,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 8
                        },
                        new
                        {
                            Id = 4,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 9
                        },
                        new
                        {
                            Id = 5,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 10
                        },
                        new
                        {
                            Id = 6,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 11
                        },
                        new
                        {
                            Id = 7,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 12
                        },
                        new
                        {
                            Id = 8,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 13
                        },
                        new
                        {
                            Id = 9,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 14
                        },
                        new
                        {
                            Id = 10,
                            ActionType = 0,
                            ActorsPosition = 5,
                            PositionId = 15
                        },
                        new
                        {
                            Id = 11,
                            ActionType = 0,
                            ActorsPosition = 5,
                            PositionId = 16
                        },
                        new
                        {
                            Id = 12,
                            ActionType = 0,
                            ActorsPosition = 5,
                            PositionId = 17
                        },
                        new
                        {
                            Id = 13,
                            ActionType = 0,
                            ActorsPosition = 6,
                            PositionId = 18
                        },
                        new
                        {
                            Id = 14,
                            ActionType = 0,
                            ActorsPosition = 6,
                            PositionId = 19
                        },
                        new
                        {
                            Id = 15,
                            ActionType = 0,
                            ActorsPosition = 1,
                            PositionId = 20
                        },
                        new
                        {
                            Id = 16,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 21
                        },
                        new
                        {
                            Id = 17,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 22
                        },
                        new
                        {
                            Id = 18,
                            ActionType = 0,
                            ActorsPosition = 5,
                            PositionId = 23
                        },
                        new
                        {
                            Id = 19,
                            ActionType = 0,
                            ActorsPosition = 6,
                            PositionId = 24
                        },
                        new
                        {
                            Id = 20,
                            ActionType = 0,
                            ActorsPosition = 1,
                            PositionId = 25
                        },
                        new
                        {
                            Id = 21,
                            ActionType = 0,
                            ActorsPosition = 1,
                            PositionId = 26
                        },
                        new
                        {
                            Id = 22,
                            ActionType = 1,
                            ActorsPosition = 2,
                            PositionId = 26
                        },
                        new
                        {
                            Id = 23,
                            ActionType = 0,
                            ActorsPosition = 6,
                            PositionId = 27
                        },
                        new
                        {
                            Id = 24,
                            ActionType = 1,
                            ActorsPosition = 2,
                            PositionId = 27
                        },
                        new
                        {
                            Id = 25,
                            ActionType = 0,
                            ActorsPosition = 5,
                            PositionId = 28
                        },
                        new
                        {
                            Id = 26,
                            ActionType = 1,
                            ActorsPosition = 2,
                            PositionId = 28
                        },
                        new
                        {
                            Id = 27,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 29
                        },
                        new
                        {
                            Id = 28,
                            ActionType = 1,
                            ActorsPosition = 2,
                            PositionId = 29
                        },
                        new
                        {
                            Id = 29,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 30
                        },
                        new
                        {
                            Id = 30,
                            ActionType = 1,
                            ActorsPosition = 2,
                            PositionId = 30
                        },
                        new
                        {
                            Id = 31,
                            ActionType = 0,
                            ActorsPosition = 6,
                            PositionId = 31
                        },
                        new
                        {
                            Id = 32,
                            ActionType = 1,
                            ActorsPosition = 1,
                            PositionId = 31
                        },
                        new
                        {
                            Id = 33,
                            ActionType = 0,
                            ActorsPosition = 5,
                            PositionId = 32
                        },
                        new
                        {
                            Id = 34,
                            ActionType = 1,
                            ActorsPosition = 1,
                            PositionId = 32
                        },
                        new
                        {
                            Id = 35,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 33
                        },
                        new
                        {
                            Id = 36,
                            ActionType = 1,
                            ActorsPosition = 1,
                            PositionId = 33
                        },
                        new
                        {
                            Id = 37,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 34
                        },
                        new
                        {
                            Id = 38,
                            ActionType = 1,
                            ActorsPosition = 1,
                            PositionId = 34
                        },
                        new
                        {
                            Id = 39,
                            ActionType = 0,
                            ActorsPosition = 5,
                            PositionId = 35
                        },
                        new
                        {
                            Id = 40,
                            ActionType = 1,
                            ActorsPosition = 6,
                            PositionId = 35
                        },
                        new
                        {
                            Id = 41,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 36
                        },
                        new
                        {
                            Id = 42,
                            ActionType = 1,
                            ActorsPosition = 6,
                            PositionId = 36
                        },
                        new
                        {
                            Id = 43,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 37
                        },
                        new
                        {
                            Id = 44,
                            ActionType = 1,
                            ActorsPosition = 6,
                            PositionId = 37
                        },
                        new
                        {
                            Id = 45,
                            ActionType = 0,
                            ActorsPosition = 4,
                            PositionId = 38
                        },
                        new
                        {
                            Id = 46,
                            ActionType = 1,
                            ActorsPosition = 5,
                            PositionId = 38
                        },
                        new
                        {
                            Id = 47,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 39
                        },
                        new
                        {
                            Id = 48,
                            ActionType = 1,
                            ActorsPosition = 5,
                            PositionId = 39
                        },
                        new
                        {
                            Id = 49,
                            ActionType = 0,
                            ActorsPosition = 3,
                            PositionId = 40
                        },
                        new
                        {
                            Id = 50,
                            ActionType = 1,
                            ActorsPosition = 4,
                            PositionId = 40
                        });
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Scenario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Scenarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Open Opportunity"
                        },
                        new
                        {
                            Id = 2,
                            Name = "3Bet Opportunity"
                        },
                        new
                        {
                            Id = 3,
                            Name = "BB Defense"
                        },
                        new
                        {
                            Id = 4,
                            Name = "3Bet Defense"
                        });
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Situation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScenarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScenarioId");

                    b.ToTable("Situations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayName = "Unopened Pot",
                            ScenarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            DisplayName = "UTG Open",
                            ScenarioId = 2
                        },
                        new
                        {
                            Id = 3,
                            DisplayName = "HJ Open",
                            ScenarioId = 2
                        },
                        new
                        {
                            Id = 4,
                            DisplayName = "CO Open",
                            ScenarioId = 2
                        },
                        new
                        {
                            Id = 5,
                            DisplayName = "BTN Open",
                            ScenarioId = 2
                        },
                        new
                        {
                            Id = 6,
                            DisplayName = "SB Open",
                            ScenarioId = 2
                        },
                        new
                        {
                            Id = 7,
                            DisplayName = "UTG Open",
                            ScenarioId = 3
                        },
                        new
                        {
                            Id = 8,
                            DisplayName = "HJ Open",
                            ScenarioId = 3
                        },
                        new
                        {
                            Id = 9,
                            DisplayName = "CO Open",
                            ScenarioId = 3
                        },
                        new
                        {
                            Id = 10,
                            DisplayName = "BTN Open",
                            ScenarioId = 3
                        },
                        new
                        {
                            Id = 11,
                            DisplayName = "SB Open",
                            ScenarioId = 3
                        },
                        new
                        {
                            Id = 12,
                            DisplayName = "BB 3Bet",
                            ScenarioId = 4
                        },
                        new
                        {
                            Id = 13,
                            DisplayName = "SB 3Bet",
                            ScenarioId = 4
                        },
                        new
                        {
                            Id = 14,
                            DisplayName = "BTN 3Bet",
                            ScenarioId = 4
                        },
                        new
                        {
                            Id = 15,
                            DisplayName = "CO 3Bet",
                            ScenarioId = 4
                        },
                        new
                        {
                            Id = 16,
                            DisplayName = "HJ 3Bet",
                            ScenarioId = 4
                        });
                });

            modelBuilder.Entity("PBandJ.Api.Entities.HandRange", b =>
                {
                    b.HasOne("PBandJ.Api.Entities.Position", null)
                        .WithOne("HandRange")
                        .HasForeignKey("PBandJ.Api.Entities.HandRange", "PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Position", b =>
                {
                    b.HasOne("PBandJ.Api.Entities.Situation", null)
                        .WithMany("Positions")
                        .HasForeignKey("SituationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PBandJ.Api.Entities.PreflopAction", b =>
                {
                    b.HasOne("PBandJ.Api.Entities.Position", null)
                        .WithMany("PreflopActions")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PBandJ.Api.Entities.Situation", b =>
                {
                    b.HasOne("PBandJ.Api.Entities.Scenario", null)
                        .WithMany("Situations")
                        .HasForeignKey("ScenarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
