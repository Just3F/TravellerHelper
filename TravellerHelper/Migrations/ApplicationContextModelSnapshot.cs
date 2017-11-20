﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TravellerHelper.Services.Database;

namespace TravellerHelper.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TravellerHelper.Models.tblCity", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("PKID");

                    b.ToTable("tblCity");
                });

            modelBuilder.Entity("TravellerHelper.Models.tblFlight", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CityFromId");

                    b.Property<long>("CityToId");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Price");

                    b.Property<int>("SeatsMax");

                    b.Property<int>("SeatsReserved");

                    b.Property<DateTime>("TimeFrom");

                    b.Property<DateTime>("TimeTo");

                    b.HasKey("PKID");

                    b.HasIndex("CityFromId");

                    b.HasIndex("CityToId");

                    b.ToTable("tblFlight");
                });

            modelBuilder.Entity("TravellerHelper.Models.tblRole", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("PKID");

                    b.ToTable("tblRole");
                });

            modelBuilder.Entity("TravellerHelper.Models.tblUser", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<long?>("RoleId");

                    b.HasKey("PKID");

                    b.HasIndex("RoleId");

                    b.ToTable("tblUser");
                });

            modelBuilder.Entity("TravellerHelper.Models.tblFlight", b =>
                {
                    b.HasOne("TravellerHelper.Models.tblCity", "CityFrom")
                        .WithMany()
                        .HasForeignKey("CityFromId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TravellerHelper.Models.tblCity", "CityTo")
                        .WithMany()
                        .HasForeignKey("CityToId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TravellerHelper.Models.tblUser", b =>
                {
                    b.HasOne("TravellerHelper.Models.tblRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
