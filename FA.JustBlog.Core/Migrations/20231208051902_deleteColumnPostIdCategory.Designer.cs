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
    [Migration("20231208051902_deleteColumnPostIdCategory")]
    partial class deleteColumnPostIdCategory
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

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(3989),
                            Description = "EF Post",
                            Name = "Entity Framework"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4003),
                            Description = "MVC Post",
                            Name = "MVC"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4004),
                            Description = "C# Post",
                            Name = "C#"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Post 1 rat hay, tuyet voi",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4333),
                            PostId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Post 1 rat hay, tuyet voi 2",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4336),
                            PostId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "Post 1 rat hay, tuyet voi 3",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4338),
                            PostId = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "Post 2 rat hay, tuyet voi",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4339),
                            PostId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "Post 2 rat hay, tuyet voi 2",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4340),
                            PostId = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "Post 3 rat hay, tuyet voi",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4341),
                            PostId = 3
                        },
                        new
                        {
                            Id = 7,
                            Content = "Post 4 rat hay, tuyet voi",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4342),
                            PostId = 4
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
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4250),
                            IsPublished = true,
                            Title = "Post 1",
                            View = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4255),
                            IsPublished = true,
                            Title = "Post 3",
                            View = 95
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4257),
                            IsPublished = true,
                            Title = "Post 4",
                            View = 20
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4260),
                            IsPublished = false,
                            Title = "Post 5",
                            View = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4262),
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

                    b.Property<int?>("TagId")
                        .IsRequired()
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
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4217),
                            Description = "MVC",
                            Name = "MVC"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4220),
                            Description = "EF Core",
                            Name = "EF Core"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4222),
                            Description = "EF Framework",
                            Name = "EF Framework"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4223),
                            Description = "ADO.NET",
                            Name = "ADO.NET"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4224),
                            Description = "C#",
                            Name = "C#"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4225),
                            Description = ".Net",
                            Name = ".Net"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4227),
                            Description = "ASP.Net",
                            Name = "ASP.Net"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4228),
                            Description = "VB",
                            Name = "VB"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4229),
                            Description = "ASP.Net MVC",
                            Name = "ASP.Net MVC"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 12, 8, 12, 19, 2, 88, DateTimeKind.Local).AddTicks(4230),
                            Description = "RestApi",
                            Name = "RestApi"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comment", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
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
