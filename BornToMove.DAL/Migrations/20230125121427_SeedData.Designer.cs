﻿// <auto-generated />
using BornToMove.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BornToMove.DAL.Migrations
{
    [DbContext(typeof(MoveContext))]
    [Migration("20230125121427_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BornToMove.DAL.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SweatRate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("move");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Ga horizontaal liggen op teentoppen en handen. Laat het lijf langzaam zakken tot de neus de grond bijna raakt. Duw het lijf terug nu omhoog tot de ellebogen bijna gestrekt zijn. Vervolgens weer laten zakken. Doe dit 20 keer zonder tussenpauzes.",
                            Name = "",
                            SweatRate = 3
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ga horizontaal liggen op teentoppen en onderarmen. Houdt deze positie 1 minuut vast.",
                            Name = "",
                            SweatRate = 3
                        },
                        new
                        {
                            Id = 3,
                            Description = "Ga staan met gestrekte armen. Zak door de knieën tot de billen de grond bijna raken. Ga weer volledig gestrekt staan. Herhaal dit 20 keer zonder tussenpauzes.",
                            Name = "",
                            SweatRate = 5
                        });
                });

            modelBuilder.Entity("BornToMove.DAL.MoveRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MoveId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<double>("Vote")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MoveId");

                    b.ToTable("MoveRating");
                });

            modelBuilder.Entity("BornToMove.DAL.MoveRating", b =>
                {
                    b.HasOne("BornToMove.DAL.Move", "Move")
                        .WithMany("Ratings")
                        .HasForeignKey("MoveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Move");
                });

            modelBuilder.Entity("BornToMove.DAL.Move", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
