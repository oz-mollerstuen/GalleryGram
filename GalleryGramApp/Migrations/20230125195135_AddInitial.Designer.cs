﻿// <auto-generated />
using System;
using GalleryGram.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalleryGramApp.Migrations
{
    [DbContext(typeof(GalleryGramContext))]
    [Migration("20230125195135_AddInitial")]
    partial class AddInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GalleryGram.Models.ApplicationUser", b =>
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

                    b.HasData(
                        new
                        {
                            Id = "8019eb7d-a9da-40ab-866d-1237ed60d1bf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2cd07851-6b12-4f5f-9085-2b16f2c0abb6",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "DAVID@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBE9pXJ65/7B39cm/XJp+iXA8DGrCGGOOaB6nJ6d/rGKYIb1TSE7Kv6ks6Efn12iZw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1cec763e-69bb-4dfe-9b2b-86df47ce99d5",
                            TwoFactorEnabled = false,
                            UserName = "david@gmail.com"
                        },
                        new
                        {
                            Id = "3915afc1-e5ed-4631-a523-110bffef0889",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9c94be69-9182-4c86-91ce-6d1a9425a57c",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ROBERT@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBGiYrNKTbJ5ZW6GOf2gXyUqK3X912YW5dzONqBKfoYwpE/DTScIWBt8w4mxLG1osQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c9f84bc7-1c1e-44ac-b165-097ad1fb55bd",
                            TwoFactorEnabled = false,
                            UserName = "robert@gmail.com"
                        },
                        new
                        {
                            Id = "fcce0f0d-0d77-4463-913a-3b937e8eb129",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "24b159c2-a049-48ca-845e-d29aad970615",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "LUCAS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ9Nc/XbBK5nl+IGV6JaEz1cAs6qqOL6frQe/STJZpkrnDPyUReVTQZtCQGAes51Mg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6cc2b1ac-468a-4ea3-89d2-bf578739d5a1",
                            TwoFactorEnabled = false,
                            UserName = "lucas@gmail.com"
                        });
                });

            modelBuilder.Entity("GalleryGram.Models.DbOrder", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("confirmation_id")
                        .HasColumnType("longtext");

                    b.Property<string>("cost")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<string>("user_id")
                        .HasColumnType("longtext");

                    b.HasKey("order_id");

                    b.ToTable("DbOrders");
                });

            modelBuilder.Entity("GalleryGram.Models.Picture", b =>
                {
                    b.Property<int>("picture_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("fileName")
                        .HasColumnType("longtext");

                    b.Property<string>("user_id")
                        .HasColumnType("longtext");

                    b.HasKey("picture_id");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            picture_id = 1,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg",
                            user_id = "8019eb7d-a9da-40ab-866d-1237ed60d1bf"
                        },
                        new
                        {
                            picture_id = 2,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/npm/npm-original-wordmark.svg",
                            user_id = "8019eb7d-a9da-40ab-866d-1237ed60d1bf"
                        },
                        new
                        {
                            picture_id = 3,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/msdos/msdos-original.svg",
                            user_id = "8019eb7d-a9da-40ab-866d-1237ed60d1bf"
                        },
                        new
                        {
                            picture_id = 4,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/markdown/markdown-original.svg",
                            user_id = "3915afc1-e5ed-4631-a523-110bffef0889"
                        },
                        new
                        {
                            picture_id = 5,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg",
                            user_id = "3915afc1-e5ed-4631-a523-110bffef0889"
                        },
                        new
                        {
                            picture_id = 6,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jquery/jquery-original.svg",
                            user_id = "3915afc1-e5ed-4631-a523-110bffef0889"
                        },
                        new
                        {
                            picture_id = 7,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jest/jest-plain.svg",
                            user_id = "fcce0f0d-0d77-4463-913a-3b937e8eb129"
                        },
                        new
                        {
                            picture_id = 8,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg",
                            user_id = "fcce0f0d-0d77-4463-913a-3b937e8eb129"
                        },
                        new
                        {
                            picture_id = 9,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg",
                            user_id = "fcce0f0d-0d77-4463-913a-3b937e8eb129"
                        });
                });

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
                    b.HasOne("GalleryGram.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GalleryGram.Models.ApplicationUser", null)
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

                    b.HasOne("GalleryGram.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GalleryGram.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
