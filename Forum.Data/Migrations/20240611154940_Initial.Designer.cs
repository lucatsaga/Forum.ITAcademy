﻿// <auto-generated />
using System;
using Forum.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Forum.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240611154940_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Forum.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TopicId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Content = "Ikomentari",
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1387),
                            TopicId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Content = "IIkomentari",
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1389),
                            TopicId = 1
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Content = "IIIkomentari",
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1390),
                            TopicId = 2
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Content = "IVkomentari",
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1392),
                            TopicId = 1
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            Content = "Vkomentari",
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1393),
                            TopicId = 3
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            Content = "VIKomentari",
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1395),
                            TopicId = 3
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            Content = "VIIKomentari",
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1396),
                            TopicId = 3
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 4,
                            Content = "VIIKomentari",
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1397),
                            TopicId = 2
                        });
                });

            modelBuilder.Entity("Forum.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1354),
                            State = "Pending",
                            Status = "Active",
                            TopicName = "TopicN1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1356),
                            State = "Pending",
                            Status = "Active",
                            TopicName = "TopicN2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1357),
                            State = "Pending",
                            Status = "Active",
                            TopicName = "TopicN3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1358),
                            State = "Pending",
                            Status = "Active",
                            TopicName = "TopicN4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1360),
                            State = "Pending",
                            Status = "Active",
                            TopicName = "TopicN5"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 4,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1361),
                            State = "Pending",
                            Status = "Active",
                            TopicName = "TopicN6"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 1,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1362),
                            State = "Pending",
                            Status = "Active",
                            TopicName = "TopicN7"
                        });
                });

            modelBuilder.Entity("Forum.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1216),
                            Email = "User1@gmail.com",
                            IsAdmin = false,
                            IsBanned = false,
                            Password = "A123",
                            UserName = "User1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1222),
                            Email = "User2@gmail.com",
                            IsAdmin = false,
                            IsBanned = false,
                            Password = "A123",
                            UserName = "User2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1224),
                            Email = "User3@gmail.com",
                            IsAdmin = false,
                            IsBanned = false,
                            Password = "A123",
                            UserName = "User3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1226),
                            Email = "User4@gmail.com",
                            IsAdmin = false,
                            IsBanned = false,
                            Password = "A123",
                            UserName = "User4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1228),
                            Email = "User5@gmail.com",
                            IsAdmin = false,
                            IsBanned = false,
                            Password = "A123",
                            UserName = "User5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1229),
                            Email = "User6@gmail.com",
                            IsAdmin = false,
                            IsBanned = false,
                            Password = "A123",
                            UserName = "User6"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1231),
                            Email = "User7@gmail.com",
                            IsAdmin = false,
                            IsBanned = false,
                            Password = "A123",
                            UserName = "User7"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 6, 11, 15, 49, 40, 61, DateTimeKind.Utc).AddTicks(1233),
                            Email = "User8@gmail.com",
                            IsAdmin = false,
                            IsBanned = false,
                            Password = "A123",
                            UserName = "User8"
                        });
                });

            modelBuilder.Entity("Forum.Entities.Comment", b =>
                {
                    b.HasOne("Forum.Entities.User", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forum.Entities.Topic", "Topic")
                        .WithMany("Comments")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Forum.Entities.Topic", b =>
                {
                    b.HasOne("Forum.Entities.User", "Author")
                        .WithMany("Topics")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Forum.Entities.Topic", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Forum.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Topics");
                });
#pragma warning restore 612, 618
        }
    }
}