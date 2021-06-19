﻿// <auto-generated />
using System;
using GiftShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GiftShop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210619093600_SweetUserRelation")]
    partial class SweetUserRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GiftShop.Models.FlowerModel", b =>
                {
                    b.Property<int>("FlowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            FlowerId = 101,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637447438702232017.jpg?w=500",
                            FlowerName = "Pink Dust",
                            FlowerPrice = 310.50m
                        },
                        new
                        {
                            FlowerId = 102,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637375823162633954.jpg?w=500",
                            FlowerName = "Breeze",
                            FlowerPrice = 322.00m
                        },
                        new
                        {
                            FlowerId = 103,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637467433600235841.jpg?w=500",
                            FlowerName = "Love Mix",
                            FlowerPrice = 360.00m
                        },
                        new
                        {
                            FlowerId = 104,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637368837979802520.jpg?width=600",
                            FlowerName = "Sleek Bouquet",
                            FlowerPrice = 200.00m
                        },
                        new
                        {
                            FlowerId = 105,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637363759603959215.jpg?width=600",
                            FlowerName = "35 Roses hand bouquet III",
                            FlowerPrice = 280.00m
                        },
                        new
                        {
                            FlowerId = 106,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637363761825283068.jpg?width=600",
                            FlowerName = "50 Roses hand bouquet II",
                            FlowerPrice = 414.00m
                        },
                        new
                        {
                            FlowerId = 107,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637448274952847223.jpg?width=600",
                            FlowerName = "White and Yellow Roses",
                            FlowerPrice = 230.50m
                        },
                        new
                        {
                            FlowerId = 108,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637503588358822359.jpg?width=600",
                            FlowerName = "Pink Roses",
                            FlowerPrice = 312.00m
                        },
                        new
                        {
                            FlowerId = 109,
                            FlowerImage = "https://floward.imgix.net/web/Files/thumPro/637502715042825399.jpg?width=600",
                            FlowerName = "Purple Tulips",
                            FlowerPrice = 430.00m
                        });
                });

            modelBuilder.Entity("GiftShop.Models.Flower_User_Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FlowerId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FlowerId");

                    b.HasIndex("UserId1");

                    b.ToTable("Flower_User_Model");
                });

            modelBuilder.Entity("GiftShop.Models.SweetModel", b =>
                {
                    b.Property<int>("SweetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SweetImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SweetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SweetPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SweetId");

                    b.ToTable("Sweets");

                    b.HasData(
                        new
                        {
                            SweetId = 201,
                            SweetImage = "https://sa-i1.fnp.com//images/pr/l/v20201205120230/delicious-fudge-cake_1.jpg",
                            SweetName = "Delicious Fudge Cake 4 Portion",
                            SweetPrice = 99.00m
                        },
                        new
                        {
                            SweetId = 202,
                            SweetImage = "https://sa-i1.fnp.com//images/pr/l/v20201205120228/red-velvet-berry-cream-cake_1.jpg",
                            SweetName = "Red Velvet Berry Cream Cake 6 Portion",
                            SweetPrice = 129.00m
                        },
                        new
                        {
                            SweetId = 203,
                            SweetImage = "https://sa-i1.fnp.com//images/pr/l/v20210402160935/creamy-red-velvet-cake_1.jpg",
                            SweetName = "Creamy Red Velvet Cake Half Kg",
                            SweetPrice = 109.00m
                        },
                        new
                        {
                            SweetId = 204,
                            SweetImage = "https://sa-i1.fnp.com/images/pr/l/v20201205120229/crunchy-chocolate-hazelnut-cake_1.jpg",
                            SweetName = "Crunchy Chocolate Hazelnut Cake 4 Portion",
                            SweetPrice = 119.00m
                        },
                        new
                        {
                            SweetId = 205,
                            SweetImage = "https://sa-i1.fnp.com/images/pr/l/v20210402160934/tales-of-taste-ice-cream-cone-cake_1.jpg",
                            SweetName = "Tales of Taste Ice Cream Cone Cake",
                            SweetPrice = 278.00m
                        },
                        new
                        {
                            SweetId = 206,
                            SweetImage = "https://sa-i1.fnp.com/images/pr/l/v20210202110031/heavenly-chocolate-cream-cake_1.jpg",
                            SweetName = "Heavenly Chocolate Cream Cake Half Kg",
                            SweetPrice = 119.00m
                        },
                        new
                        {
                            SweetId = 207,
                            SweetImage = "https://sa-i1.fnp.com//images/pr/l/v20201215142751/the-gentleman-theme-cake_1.jpg",
                            SweetName = "The Gentleman Theme Cake 8 Portions Vanilla",
                            SweetPrice = 279.00m
                        },
                        new
                        {
                            SweetId = 208,
                            SweetImage = "https://sa-i1.fnp.com//images/pr/l/v20210526180156/candy-topped-chocolate-cake_1.jpg",
                            SweetName = "Candy Topped Chocolate Cake Half Kg",
                            SweetPrice = 129.00m
                        },
                        new
                        {
                            SweetId = 209,
                            SweetImage = "https://sa-i1.fnp.com/images/pr/l/v20201215142740/princess-theme-cake_1.jpg",
                            SweetName = "Princess Theme Cake 12 Portions Vanilla",
                            SweetPrice = 399.00m
                        });
                });

            modelBuilder.Entity("GiftShop.Models.Sweet_User_Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SweetId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SweetId");

                    b.HasIndex("UserId1");

                    b.ToTable("Sweet_User_Model");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
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

            modelBuilder.Entity("GiftShop.Data.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("GiftShop.Models.Flower_User_Model", b =>
                {
                    b.HasOne("GiftShop.Models.FlowerModel", "Flower")
                        .WithMany("Flower_User")
                        .HasForeignKey("FlowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiftShop.Data.ApplicationUser", "User")
                        .WithMany("Flower_User")
                        .HasForeignKey("UserId1");

                    b.Navigation("Flower");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GiftShop.Models.Sweet_User_Model", b =>
                {
                    b.HasOne("GiftShop.Models.SweetModel", "Sweet")
                        .WithMany("Sweet_User")
                        .HasForeignKey("SweetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiftShop.Data.ApplicationUser", "User")
                        .WithMany("Sweet_User")
                        .HasForeignKey("UserId1");

                    b.Navigation("Sweet");

                    b.Navigation("User");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GiftShop.Models.FlowerModel", b =>
                {
                    b.Navigation("Flower_User");
                });

            modelBuilder.Entity("GiftShop.Models.SweetModel", b =>
                {
                    b.Navigation("Sweet_User");
                });

            modelBuilder.Entity("GiftShop.Data.ApplicationUser", b =>
                {
                    b.Navigation("Flower_User");

                    b.Navigation("Sweet_User");
                });
#pragma warning restore 612, 618
        }
    }
}
