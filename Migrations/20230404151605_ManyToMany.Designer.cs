﻿// <auto-generated />
using EFMVC_odev.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFMVC_odev.Migrations
{
    [DbContext(typeof(MVCContext))]
    [Migration("20230404151605_ManyToMany")]
    partial class ManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFMVC_odev.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("SubjectCredets")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectTerm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("EFMVC_odev.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<int>("TeacherAddres")
                        .HasColumnType("int");

                    b.Property<int>("TeacherAge")
                        .HasColumnType("int");

                    b.Property<int>("TeacherName")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SubjectTeacher", b =>
                {
                    b.Property<int>("SubjectTeachersTeacherId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherSubjectsSubjectId")
                        .HasColumnType("int");

                    b.HasKey("SubjectTeachersTeacherId", "TeacherSubjectsSubjectId");

                    b.HasIndex("TeacherSubjectsSubjectId");

                    b.ToTable("SubjectTeacher");
                });

            modelBuilder.Entity("SubjectTeacher", b =>
                {
                    b.HasOne("EFMVC_odev.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("SubjectTeachersTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFMVC_odev.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("TeacherSubjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
