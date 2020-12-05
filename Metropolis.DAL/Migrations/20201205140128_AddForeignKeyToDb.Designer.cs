﻿// <auto-generated />
using System;
using Metropolis.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Metropolis.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201205140128_AddForeignKeyToDb")]
    partial class AddForeignKeyToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Metropolis.DAL.Entities.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ScheduledDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StreetFk")
                        .HasColumnType("int");

                    b.HasKey("ActivityId");

                    b.HasIndex("StreetFk");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Metropolis.DAL.Entities.Street", b =>
                {
                    b.Property<int>("StreetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlternativeStreet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreetId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("Metropolis.DAL.Entities.Activity", b =>
                {
                    b.HasOne("Metropolis.DAL.Entities.Street", "Street")
                        .WithMany()
                        .HasForeignKey("StreetFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}