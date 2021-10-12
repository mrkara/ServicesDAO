﻿// <auto-generated />
using System;
using DAO_DbService.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAO_DbService.Migrations
{
    [DbContext(typeof(dao_maindb_context))]
    partial class dao_maindb_contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("DAO_DbService.Models.Auction", b =>
                {
                    b.Property<int>("AuctionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<int>("JobID")
                        .HasColumnType("int");

                    b.Property<int>("JobPosterUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<int>("WinnerAuctionBidID")
                        .HasColumnType("int");

                    b.HasKey("AuctionID");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("DAO_DbService.Models.AuctionBid", b =>
                {
                    b.Property<int>("AuctionBidID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuctionID")
                        .HasColumnType("int");

                    b.Property<bool>("IsInternal")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("ReputationStake")
                        .HasColumnType("double");

                    b.Property<string>("Time")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AuctionBidID");

                    b.ToTable("AuctionBids");
                });

            modelBuilder.Entity("DAO_DbService.Models.JobPost", b =>
                {
                    b.Property<int>("JobID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<double>("DosPaid")
                        .HasColumnType("double");

                    b.Property<string>("JobDescription")
                        .HasColumnType("text");

                    b.Property<string>("TimeFrame")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("JobID");

                    b.ToTable("JobPosts");
                });

            modelBuilder.Entity("DAO_DbService.Models.JobPostComment", b =>
                {
                    b.Property<int>("JobPostCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("JobID")
                        .HasColumnType("int");

                    b.Property<int>("SubCommentID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("JobPostCommentID");

                    b.ToTable("JobPostComments");
                });

            modelBuilder.Entity("DAO_DbService.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int?>("FailedLoginCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("KYCStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("text");

                    b.Property<bool>("Newsletter")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("text");

                    b.Property<string>("UserAlias")
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAO_DbService.Models.UserKYC", b =>
                {
                    b.Property<int>("UserKYCID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserType")
                        .HasColumnType("text");

                    b.HasKey("UserKYCID");

                    b.ToTable("UserKYCs");
                });
#pragma warning restore 612, 618
        }
    }
}
