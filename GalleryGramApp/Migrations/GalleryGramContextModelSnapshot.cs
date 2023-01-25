﻿// <auto-generated />
using System;
using GalleryGram.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalleryGram.Migrations
{
    [DbContext(typeof(GalleryGramContext))]
    partial class GalleryGramContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "689c3af3-0b75-47fa-953f-3dd4b885629c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4f0a4b05-743f-4153-8142-62dcfe7b05f1",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "DAVID@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA1xUH4qhlhH2+S0JY8CqjxQ4CmOS3zd9QXt3i63/GAJbjtlLDOB1Q60uAo6YLTGtw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95e307d0-e2d8-4199-8c98-0e5ebbef14b0",
                            TwoFactorEnabled = false,
                            UserName = "david@gmail.com"
                        },
                        new
                        {
                            Id = "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "18b3af8b-db75-41fa-9372-04b9a21870cc",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ROBERT@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENHr2MVXV8XhDsPUnM5e4B8y7jTCqwJgdB1rzaWf6wQUrV5HkGFZ6vmpA7Y7HdpEXA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e57883c7-3b9c-4764-b946-91da5b65cfd1",
                            TwoFactorEnabled = false,
                            UserName = "robert@gmail.com"
                        },
                        new
                        {
                            Id = "10b0264f-6519-4e74-92d5-691c1550ee2e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e72c1efd-8afa-483e-afd3-6ba457f3258e",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "LUCAS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEN1fD+vuPJLWeY1tDW6MDFjFQAhwiJa8SjQy6C4UGvr0y/CkKIvIpDOqU29DzXr35A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2b1df124-7843-4177-a874-5c353d75243f",
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
                            user_id = "689c3af3-0b75-47fa-953f-3dd4b885629c"
                        },
                        new
                        {
                            picture_id = 2,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/npm/npm-original-wordmark.svg",
                            user_id = "689c3af3-0b75-47fa-953f-3dd4b885629c"
                        },
                        new
                        {
                            picture_id = 3,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/msdos/msdos-original.svg",
                            user_id = "689c3af3-0b75-47fa-953f-3dd4b885629c"
                        },
                        new
                        {
                            picture_id = 4,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/markdown/markdown-original.svg",
                            user_id = "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14"
                        },
                        new
                        {
                            picture_id = 5,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg",
                            user_id = "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14"
                        },
                        new
                        {
                            picture_id = 6,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jquery/jquery-original.svg",
                            user_id = "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14"
                        },
                        new
                        {
                            picture_id = 7,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jest/jest-plain.svg",
                            user_id = "10b0264f-6519-4e74-92d5-691c1550ee2e"
                        },
                        new
                        {
                            picture_id = 8,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg",
                            user_id = "10b0264f-6519-4e74-92d5-691c1550ee2e"
                        },
                        new
                        {
                            picture_id = 9,
                            fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg",
                            user_id = "10b0264f-6519-4e74-92d5-691c1550ee2e"
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
