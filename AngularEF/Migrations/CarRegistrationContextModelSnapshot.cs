﻿// <auto-generated />
using System;
using AngularEF.DataRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngularEF.Migrations
{
    [DbContext(typeof(CarRegistrationContext))]
    partial class CarRegistrationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AngularEF.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacture")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ProductionDate")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("AngularEF.Models.CheckUp", b =>
                {
                    b.Property<int>("CheckUpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NextCheckUp")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("int");

                    b.HasKey("CheckUpId");

                    b.HasIndex("RegistrationId");

                    b.ToTable("CheckUps");
                });

            modelBuilder.Entity("AngularEF.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("cpr")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("AngularEF.Models.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CurrentCheckUpDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FirstDayRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistrationIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegistrationId");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("CarOwner", b =>
                {
                    b.Property<int>("CarsCarId")
                        .HasColumnType("int");

                    b.Property<int>("OwnersOwnerId")
                        .HasColumnType("int");

                    b.HasKey("CarsCarId", "OwnersOwnerId");

                    b.HasIndex("OwnersOwnerId");

                    b.ToTable("CarOwner");
                });

            modelBuilder.Entity("AngularEF.Models.CheckUp", b =>
                {
                    b.HasOne("AngularEF.Models.Registration", "Registration")
                        .WithMany("CheckUps")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("AngularEF.Models.Registration", b =>
                {
                    b.HasOne("AngularEF.Models.Car", "Car")
                        .WithOne("Registration")
                        .HasForeignKey("AngularEF.Models.Registration", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarOwner", b =>
                {
                    b.HasOne("AngularEF.Models.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngularEF.Models.Owner", null)
                        .WithMany()
                        .HasForeignKey("OwnersOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AngularEF.Models.Car", b =>
                {
                    b.Navigation("Registration");
                });

            modelBuilder.Entity("AngularEF.Models.Registration", b =>
                {
                    b.Navigation("CheckUps");
                });
#pragma warning restore 612, 618
        }
    }
}