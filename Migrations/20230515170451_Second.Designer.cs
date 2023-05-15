﻿// <auto-generated />
using System;
using HockeyManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HockeyManager.Migrations
{
    [DbContext(typeof(HockeyManagerDbContext))]
    [Migration("20230515170451_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("HockeyManager.Player", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("HockeyManager.Stats", b =>
                {
                    b.Property<int>("StatsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Assists")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CleanSheets")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Goals")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlusMinus")
                        .HasColumnType("INTEGER");

                    b.HasKey("StatsId");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("HockeyManager.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Conference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
