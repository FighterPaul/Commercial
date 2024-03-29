﻿// <auto-generated />
using System;
using Commercial_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Commercial_1.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240302025831_DB_30")]
    partial class DB_30
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Commercial_1.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex("CreatorUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Commercial_1.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Commercial_1.Models.User_Post_Member", b =>
                {
                    b.Property<int>("User_Post_MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Post_MemberId"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("User_Post_MemberId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("User_Post_Members");
                });

            modelBuilder.Entity("Commercial_1.Models.Post", b =>
                {
                    b.HasOne("Commercial_1.Models.User", "Creator")
                        .WithMany("Post_List")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Commercial_1.Models.User_Post_Member", b =>
                {
                    b.HasOne("Commercial_1.Models.Post", "Post")
                        .WithMany("Member_List")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Commercial_1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Commercial_1.Models.User", null)
                        .WithMany("Attend_List")
                        .HasForeignKey("UserId1");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Commercial_1.Models.Post", b =>
                {
                    b.Navigation("Member_List");
                });

            modelBuilder.Entity("Commercial_1.Models.User", b =>
                {
                    b.Navigation("Attend_List");

                    b.Navigation("Post_List");
                });
#pragma warning restore 612, 618
        }
    }
}
