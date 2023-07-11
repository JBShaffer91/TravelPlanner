﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelPlanner.Models;

#nullable disable

namespace TravelPlanner.Migrations
{
    [DbContext(typeof(TravelPlannerContext))]
    partial class TravelPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TravelPlanner.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TravelPlanner.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("DestinationName")
                        .HasColumnType("longtext");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("TravelPlanner.Models.DestinationTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("TripId");

                    b.ToTable("DestinationTrips");
                });

            modelBuilder.Entity("TravelPlanner.Models.Itinerary", b =>
                {
                    b.Property<int>("ItineraryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("ItineraryId");

                    b.ToTable("Itineraries");
                });

            modelBuilder.Entity("TravelPlanner.Models.Lodging", b =>
                {
                    b.Property<int>("LodgingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LodgingName")
                        .HasColumnType("longtext");

                    b.Property<string>("LodgingType")
                        .HasColumnType("longtext");

                    b.HasKey("LodgingId");

                    b.ToTable("Lodgings");
                });

            modelBuilder.Entity("TravelPlanner.Models.LodgingTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LodgingId")
                        .HasColumnType("int");

                    b.Property<int?>("LodgingTripId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LodgingId");

                    b.HasIndex("LodgingTripId");

                    b.HasIndex("TripId");

                    b.ToTable("LodgingTrips");
                });

            modelBuilder.Entity("TravelPlanner.Models.Transportation", b =>
                {
                    b.Property<int>("TransportationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ArrivalLocation")
                        .HasColumnType("longtext");

                    b.Property<string>("Company")
                        .HasColumnType("longtext");

                    b.Property<string>("DepartureLocation")
                        .HasColumnType("longtext");

                    b.Property<string>("Mode")
                        .HasColumnType("longtext");

                    b.Property<string>("TransportationName")
                        .HasColumnType("longtext");

                    b.HasKey("TransportationId");

                    b.ToTable("Transportations");
                });

            modelBuilder.Entity("TravelPlanner.Models.TransportationTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TransportationId")
                        .HasColumnType("int");

                    b.Property<int?>("TransportationTripId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransportationId");

                    b.HasIndex("TransportationTripId");

                    b.HasIndex("TripId");

                    b.ToTable("TransportationTrips");
                });

            modelBuilder.Entity("TravelPlanner.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("LodgingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("TransportationId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("TripId");

                    b.HasIndex("LodgingId");

                    b.HasIndex("TransportationId");

                    b.HasIndex("UserId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TravelPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TravelPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TravelPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelPlanner.Models.DestinationTrip", b =>
                {
                    b.HasOne("TravelPlanner.Models.Destination", "Destination")
                        .WithMany("DestinationTrips")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelPlanner.Models.Trip", "Trip")
                        .WithMany("DestinationTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TravelPlanner.Models.LodgingTrip", b =>
                {
                    b.HasOne("TravelPlanner.Models.Lodging", "Lodging")
                        .WithMany("LodgingTrips")
                        .HasForeignKey("LodgingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelPlanner.Models.LodgingTrip", null)
                        .WithMany("LodgingTrips")
                        .HasForeignKey("LodgingTripId");

                    b.HasOne("TravelPlanner.Models.Trip", "Trip")
                        .WithMany("LodgingTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lodging");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TravelPlanner.Models.TransportationTrip", b =>
                {
                    b.HasOne("TravelPlanner.Models.Transportation", "Transportation")
                        .WithMany("TransportationTrips")
                        .HasForeignKey("TransportationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelPlanner.Models.TransportationTrip", null)
                        .WithMany("TransportationTrips")
                        .HasForeignKey("TransportationTripId");

                    b.HasOne("TravelPlanner.Models.Trip", "Trip")
                        .WithMany("TransportationTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Transportation");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TravelPlanner.Models.Trip", b =>
                {
                    b.HasOne("TravelPlanner.Models.Lodging", "Lodging")
                        .WithMany()
                        .HasForeignKey("LodgingId");

                    b.HasOne("TravelPlanner.Models.Transportation", "Transportation")
                        .WithMany()
                        .HasForeignKey("TransportationId");

                    b.HasOne("TravelPlanner.Models.ApplicationUser", "User")
                        .WithMany("Trips")
                        .HasForeignKey("UserId");

                    b.Navigation("Lodging");

                    b.Navigation("Transportation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TravelPlanner.Models.ApplicationUser", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("TravelPlanner.Models.Destination", b =>
                {
                    b.Navigation("DestinationTrips");
                });

            modelBuilder.Entity("TravelPlanner.Models.Lodging", b =>
                {
                    b.Navigation("LodgingTrips");
                });

            modelBuilder.Entity("TravelPlanner.Models.LodgingTrip", b =>
                {
                    b.Navigation("LodgingTrips");
                });

            modelBuilder.Entity("TravelPlanner.Models.Transportation", b =>
                {
                    b.Navigation("TransportationTrips");
                });

            modelBuilder.Entity("TravelPlanner.Models.TransportationTrip", b =>
                {
                    b.Navigation("TransportationTrips");
                });

            modelBuilder.Entity("TravelPlanner.Models.Trip", b =>
                {
                    b.Navigation("DestinationTrips");

                    b.Navigation("LodgingTrips");

                    b.Navigation("TransportationTrips");
                });
#pragma warning restore 612, 618
        }
    }
}
