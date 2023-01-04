﻿// <auto-generated />
using System;
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
    [Migration("20230104025703_AdjustedRoutinePeriodRelationship")]
    partial class AdjustedRoutinePeriodRelationship
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

                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ExercisesId");

                    b.HasIndex("ExercisesId");

                    b.ToTable("ExerciseCategories", (string)null);
                });

            modelBuilder.Entity("ExerciseMuscle", b =>
                {
                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("MusclesWorkedId")
                        .HasColumnType("int");

                    b.HasKey("ExercisesId", "MusclesWorkedId");

                    b.HasIndex("MusclesWorkedId");

                    b.ToTable("ExerciseMuscles", (string)null);
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
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

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntensityMeasure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentationImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeExpendInSec")
                        .HasColumnType("int");

                    b.Property<string>("Video")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Muscles");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Routine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentationImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoutineLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Routines");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.RoutineExercises", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("RoutineId")
                        .HasColumnType("int");

                    b.Property<int>("RoutinePeriodDetailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("RoutineId");

                    b.HasIndex("RoutinePeriodDetailId");

                    b.ToTable("RoutineExercise");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.RoutinePeriodDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DayNumber")
                        .HasColumnType("int");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RoutinePeriodDetail");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Fail")
                        .HasColumnType("bit");

                    b.Property<int>("Intensity")
                        .HasColumnType("int");

                    b.Property<int>("Repetitions")
                        .HasColumnType("int");

                    b.Property<int>("RestInSec")
                        .HasColumnType("int");

                    b.Property<int>("RoutineExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("SerieNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoutineExerciseId");

                    b.ToTable("Serie");
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
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExerciseMuscle", b =>
                {
                    b.HasOne("GymTrainingControl.Domain.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTrainingControl.Domain.Models.Muscle", null)
                        .WithMany()
                        .HasForeignKey("MusclesWorkedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.RoutineExercises", b =>
                {
                    b.HasOne("GymTrainingControl.Domain.Models.Exercise", "Exercise")
                        .WithMany("ExercisesRoutine")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTrainingControl.Domain.Models.Routine", "Routine")
                        .WithMany("RoutineExercises")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTrainingControl.Domain.Models.RoutinePeriodDetail", "RoutinePeriodDetail")
                        .WithMany()
                        .HasForeignKey("RoutinePeriodDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Routine");

                    b.Navigation("RoutinePeriodDetail");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Serie", b =>
                {
                    b.HasOne("GymTrainingControl.Domain.Models.RoutineExercises", "RoutineExercise")
                        .WithMany("Series")
                        .HasForeignKey("RoutineExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoutineExercise");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Exercise", b =>
                {
                    b.Navigation("ExercisesRoutine");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.Routine", b =>
                {
                    b.Navigation("RoutineExercises");
                });

            modelBuilder.Entity("GymTrainingControl.Domain.Models.RoutineExercises", b =>
                {
                    b.Navigation("Series");
                });
#pragma warning restore 612, 618
        }
    }
}