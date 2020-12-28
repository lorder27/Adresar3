﻿// <auto-generated />
using Adresar3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adresar3.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20201228135638_InitContact")]
    partial class InitContact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Adresar3.Models.Contact", b =>
                {
                    b.Property<string>("OwnerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("ContactNum")
                        .HasColumnType("int");

                    b.Property<int>("ContactNum1")
                        .HasColumnType("int");

                    b.Property<int>("ContactNum2")
                        .HasColumnType("int");

                    b.Property<int>("ContactNum3")
                        .HasColumnType("int");

                    b.Property<int>("ContactNum4")
                        .HasColumnType("int");

                    b.Property<int>("ContactNum5")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerID");

                    b.ToTable("Contact");
                });
#pragma warning restore 612, 618
        }
    }
}
