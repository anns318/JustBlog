﻿// <auto-generated />
using System;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20231206073238_addPostPublishedColumn")]
    partial class addPostPublishedColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(3900),
                            Description = "EF Post",
                            Name = "Entity Framework",
                            PostId = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(3916),
                            Description = "MVC Post",
                            Name = "MVC",
                            PostId = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(3917),
                            Description = "C# Post",
                            Name = "C#",
                            PostId = 0
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("View")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4167),
                            IsPublished = true,
                            Title = "Post 1",
                            View = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4171),
                            IsPublished = true,
                            Title = "Post 3",
                            View = 95
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4173),
                            IsPublished = true,
                            Title = "Post 4",
                            View = 20
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4174),
                            IsPublished = false,
                            Title = "Post 5",
                            View = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4176),
                            IsPublished = false,
                            Title = "Post 2",
                            View = 0
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostRate");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostId = 1,
                            Rate = 1
                        },
                        new
                        {
                            Id = 2,
                            PostId = 1,
                            Rate = 2
                        },
                        new
                        {
                            Id = 3,
                            PostId = 1,
                            Rate = 3
                        },
                        new
                        {
                            Id = 4,
                            PostId = 1,
                            Rate = 4
                        },
                        new
                        {
                            Id = 5,
                            PostId = 1,
                            Rate = 5
                        },
                        new
                        {
                            Id = 6,
                            PostId = 2,
                            Rate = 1
                        },
                        new
                        {
                            Id = 7,
                            PostId = 2,
                            Rate = 5
                        },
                        new
                        {
                            Id = 8,
                            PostId = 2,
                            Rate = 4
                        },
                        new
                        {
                            Id = 9,
                            PostId = 3,
                            Rate = 1
                        },
                        new
                        {
                            Id = 10,
                            PostId = 3,
                            Rate = 2
                        },
                        new
                        {
                            Id = 11,
                            PostId = 3,
                            Rate = 1
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostId = 1,
                            TagId = 1
                        },
                        new
                        {
                            Id = 2,
                            PostId = 1,
                            TagId = 2
                        },
                        new
                        {
                            Id = 3,
                            PostId = 1,
                            TagId = 3
                        },
                        new
                        {
                            Id = 4,
                            PostId = 2,
                            TagId = 1
                        },
                        new
                        {
                            Id = 5,
                            PostId = 2,
                            TagId = 3
                        },
                        new
                        {
                            Id = 6,
                            PostId = 3,
                            TagId = 5
                        },
                        new
                        {
                            Id = 7,
                            PostId = 3,
                            TagId = 6
                        },
                        new
                        {
                            Id = 8,
                            PostId = 3,
                            TagId = 1
                        },
                        new
                        {
                            Id = 9,
                            PostId = 4,
                            TagId = 9
                        },
                        new
                        {
                            Id = 10,
                            PostId = 5,
                            TagId = 7
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4132),
                            Description = "MVC",
                            Name = "MVC"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4135),
                            Description = "EF Core",
                            Name = "EF Core"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4136),
                            Description = "EF Framework",
                            Name = "EF Framework"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4137),
                            Description = "ADO.NET",
                            Name = "ADO.NET"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4138),
                            Description = "C#",
                            Name = "C#"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4139),
                            Description = ".Net",
                            Name = ".Net"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4140),
                            Description = "ASP.Net",
                            Name = "ASP.Net"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4141),
                            Description = "VB",
                            Name = "VB"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4142),
                            Description = "ASP.Net MVC",
                            Name = "ASP.Net MVC"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4143),
                            Description = "RestApi",
                            Name = "RestApi"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Category", "Category")
                        .WithMany("Post")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostRate", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("PostRate")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTag", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Navigation("Post");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Navigation("PostRate");

                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}
