﻿// <auto-generated />
using System;
using BlogActivity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogActivity.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20220513014304_BlogDbMigration")]
    partial class BlogDbMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogActivity.Models.CommentModel", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserCommentUserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("UserCommentUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BlogActivity.Models.PostModel", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserPostUserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("UserPostUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BlogActivity.Models.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BlogActivity.Models.CommentModel", b =>
                {
                    b.HasOne("BlogActivity.Models.UserModel", "UserComment")
                        .WithMany("Comments")
                        .HasForeignKey("UserCommentUserId");
                });

            modelBuilder.Entity("BlogActivity.Models.PostModel", b =>
                {
                    b.HasOne("BlogActivity.Models.UserModel", "UserPost")
                        .WithMany("Posts")
                        .HasForeignKey("UserPostUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
