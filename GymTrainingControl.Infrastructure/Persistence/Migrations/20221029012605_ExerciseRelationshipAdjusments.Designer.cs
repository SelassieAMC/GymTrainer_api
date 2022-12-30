﻿// <auto-generated />
using GymTrainingControl.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221029012605_ExerciseRelationshipAdjusments")]
    partial class ExerciseRelationshipAdjusments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryExercise", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryExercisesId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "CategoryExercisesId");

                    b.HasIndex("CategoryExercisesId");

                    b.ToTable("CategoryExercise");
                });

            modelBuilder.Entity("ExerciseMuscle", b =>
                {
                    b.Property<int>("MuscleExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("MusclesWorkedId")
                        .HasColumnType("int");

                    b.HasKey("MuscleExercisesId", "MusclesWorkedId");

                    b.HasIndex("MusclesWorkedId");

                    b.ToTable("ExerciseMuscle");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Muscle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Muscles");
                });

            modelBuilder.Entity("CategoryExercise", b =>
                {
                    b.HasOne("GymTrainingControl.Domain.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTrainingControl.Domain.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("CategoryExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExerciseMuscle", b =>
                {
                    b.HasOne("GymTrainingControl.Domain.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("MuscleExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTrainingControl.Domain.Models.Muscle", null)
                        .WithMany()
                        .HasForeignKey("MusclesWorkedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
