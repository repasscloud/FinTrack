﻿// <auto-generated />
using FinTrack.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinTrack.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231022105434_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("FinTrack.Models.Clients.BasicClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ABN")
                        .HasColumnType("TEXT");

                    b.Property<string>("ACN")
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorsName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BasicClients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 1",
                            EntityName = "Company 1 Pty Ltd"
                        },
                        new
                        {
                            Id = 2,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 2",
                            EntityName = "Company 2 Pty Ltd"
                        },
                        new
                        {
                            Id = 3,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 3",
                            EntityName = "Company 3 Pty Ltd"
                        },
                        new
                        {
                            Id = 4,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 4",
                            EntityName = "Company 4 Pty Ltd"
                        },
                        new
                        {
                            Id = 5,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 5",
                            EntityName = "Company 5 Pty Ltd"
                        },
                        new
                        {
                            Id = 6,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 6",
                            EntityName = "Company 6 Pty Ltd"
                        },
                        new
                        {
                            Id = 7,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 7",
                            EntityName = "Company 7 Pty Ltd"
                        },
                        new
                        {
                            Id = 8,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 8",
                            EntityName = "Company 8 Pty Ltd"
                        },
                        new
                        {
                            Id = 9,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 9",
                            EntityName = "Company 9 Pty Ltd"
                        },
                        new
                        {
                            Id = 10,
                            ABN = "01234567890",
                            ACN = "123456789",
                            DirectorsName = "Director Number 10",
                            EntityName = "Company 10 Pty Ltd"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
