﻿// <auto-generated />
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240510044345_AddStudentNameColumn")]
    partial class AddStudentNameColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("DemoMVC.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Person");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("DemoMVC.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DemoMVC.Models.Employee", b =>
                {
                    b.HasBaseType("DemoMVC.Models.Person");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DemoMVC.Models.Employee", b =>
                {
                    b.HasOne("DemoMVC.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DemoMVC.Models.Employee", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}