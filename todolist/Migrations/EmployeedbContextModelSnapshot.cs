﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using todolist.Models;

namespace todolist.Migrations
{
    [DbContext(typeof(EmployeedbContext))]
    partial class EmployeedbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("todolist.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeID")
                        .HasColumnType("char(36)")
                        .HasComment("Khóa chính")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)")
                        .HasComment("Ngày sinh");

                    b.Property<string>("EmployeeCode")
                        .HasColumnType("varchar(20)")
                        .HasComment("Mã h? so")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(100)")
                        .HasComment("H?")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasComment("H? và tên")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(100)")
                        .HasComment("Tên")
                        .HasAnnotation("MySql:CharSet", "utf8")
                        .HasAnnotation("MySql:Collation", "utf8_general_ci");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmployeeId")
                        .IsUnique()
                        .HasName("IX_EmployeeID");

                    b.ToTable("employee");

                    b.HasComment("h? so nhân viên");
                });
#pragma warning restore 612, 618
        }
    }
}
