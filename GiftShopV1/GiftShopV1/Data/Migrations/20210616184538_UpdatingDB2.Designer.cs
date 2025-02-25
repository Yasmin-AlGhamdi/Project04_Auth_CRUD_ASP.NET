﻿// <auto-generated />
using System;
using GiftShopV1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GiftShopV1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210616184538_UpdatingDB2")]
    partial class UpdatingDB2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GiftShopV1.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GiftShopV1.Models.CustomerModel", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "Alexia@hotmail.com",
                            FirstName = "Alexia",
                            LastName = "Perry",
                            Location = "NY",
                            Password = "123",
                            PhoneNumber = "055-569-9110",
                            Username = "AlexPer"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "RitaF@hotmail.com",
                            FirstName = "Rita",
                            LastName = "Farr",
                            Location = "LA",
                            Password = "234",
                            PhoneNumber = "050-569-9110",
                            Username = "RitaF"
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "TonyR@hotmail.com",
                            FirstName = "Tony",
                            LastName = "Roberts",
                            Location = "FL",
                            Password = "345",
                            PhoneNumber = "054-932-6548",
                            Username = "TonyRob"
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "AmeliaO@hotmail.com",
                            FirstName = "Amelia",
                            LastName = "Owen",
                            Location = "CA",
                            Password = "456",
                            PhoneNumber = "051-436-5094",
                            Username = "AmeliaOwen"
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "KyleF@hotmail.com",
                            FirstName = "Kyle",
                            LastName = "Fox",
                            Location = "NY",
                            Password = "567",
                            PhoneNumber = "059-330-4393",
                            Username = "KyFox"
                        });
                });

            modelBuilder.Entity("GiftShopV1.Models.FlowerModel", b =>
                {
                    b.Property<int>("FlowerId")
                        .HasColumnType("int");

                    b.Property<string>("FlowerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlowerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FlowerPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FlowerId");

                    b.ToTable("Flowers");

                    b.HasData(
                        new
                        {
                            FlowerId = 10,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637447438702232017.jpg?w=500",
                            FlowerName = "Pink Dust",
                            FlowerPrice = 310.50m
                        },
                        new
                        {
                            FlowerId = 11,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637375823162633954.jpg?w=500",
                            FlowerName = "Breeze",
                            FlowerPrice = 322.00m
                        },
                        new
                        {
                            FlowerId = 12,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637467433600235841.jpg?w=500",
                            FlowerName = "Love Mix",
                            FlowerPrice = 360.00m
                        },
                        new
                        {
                            FlowerId = 13,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637368837979802520.jpg?width=600",
                            FlowerName = "Sleek Bouquet",
                            FlowerPrice = 200.00m
                        },
                        new
                        {
                            FlowerId = 14,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637363759603959215.jpg?width=600",
                            FlowerName = "35 Roses hand bouquet III",
                            FlowerPrice = 280.00m
                        },
                        new
                        {
                            FlowerId = 15,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637363761825283068.jpg?width=600",
                            FlowerName = "50 Roses hand bouquet II",
                            FlowerPrice = 414.00m
                        },
                        new
                        {
                            FlowerId = 16,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637448274952847223.jpg?width=600",
                            FlowerName = "White and Yellow Roses",
                            FlowerPrice = 230.50m
                        },
                        new
                        {
                            FlowerId = 17,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637503588358822359.jpg?width=600",
                            FlowerName = "Pink Roses",
                            FlowerPrice = 312.00m
                        },
                        new
                        {
                            FlowerId = 18,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637502715042825399.jpg?width=600",
                            FlowerName = "Purple Tulips",
                            FlowerPrice = 430.00m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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
                    b.HasOne("GiftShopV1.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GiftShopV1.Data.ApplicationUser", null)
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

                    b.HasOne("GiftShopV1.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GiftShopV1.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
