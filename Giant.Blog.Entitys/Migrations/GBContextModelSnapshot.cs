﻿// <auto-generated />
using System;
using Giant.Blog.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Giant.Blog.Entitys.Migrations
{
    [DbContext(typeof(GBContext))]
    partial class GBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Giant.Blog.Entitys.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CustomUrl")
                        .HasMaxLength(1000);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Logo")
                        .HasMaxLength(1000);

                    b.Property<string>("Notice")
                        .HasMaxLength(1000);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SubTitle")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Url")
                        .HasMaxLength(1000);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Giant.Blog.Entitys.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowComment");

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("PushTime");

                    b.Property<int>("Status");

                    b.Property<string>("Summary")
                        .HasMaxLength(1000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Giant.Blog.Entitys.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("IpAddr")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.ToTable("PostComment");
                });

            modelBuilder.Entity("Giant.Blog.Entitys.PostSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<int>("CommentCount");

                    b.Property<int>("PostId");

                    b.Property<int>("StarCount");

                    b.Property<int>("ViewCount");

                    b.HasKey("Id");

                    b.ToTable("PostSummary");
                });

            modelBuilder.Entity("Giant.Blog.Entitys.PostTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<int>("PostId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("Giant.Blog.Entitys.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
