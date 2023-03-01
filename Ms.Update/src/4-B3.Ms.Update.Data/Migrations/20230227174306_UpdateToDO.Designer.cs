﻿// <auto-generated />
using System;
using B3.Ms.Update.Data.Repositories.Base.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace B3.Ms.Update.Data.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20230227174306_UpdateToDO")]
    partial class UpdateToDO
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("B3.Ms.Update.Domain.Aggregates.ToDos.Entities.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ConclusionDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ConclusionDate");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreateDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Description");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("ToDo", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
