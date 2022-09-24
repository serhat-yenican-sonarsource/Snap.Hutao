﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Snap.Hutao.Context.Database;

#nullable disable

namespace Snap.Hutao.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220924135810_AddAvatarInfo")]
    partial class AddAvatarInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Snap.Hutao.Model.Entity.Achievement", b =>
                {
                    b.Property<Guid>("InnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ArchiveId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("InnerId");

                    b.HasIndex("ArchiveId");

                    b.ToTable("achievements");
                });

            modelBuilder.Entity("Snap.Hutao.Model.Entity.AchievementArchive", b =>
                {
                    b.Property<Guid>("InnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InnerId");

                    b.ToTable("achievement_archives");
                });

            modelBuilder.Entity("Snap.Hutao.Model.Entity.AvatarInfo", b =>
                {
                    b.Property<Guid>("InnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InnerId");

                    b.ToTable("avatar_infos");
                });

            modelBuilder.Entity("Snap.Hutao.Model.Entity.GachaArchive", b =>
                {
                    b.Property<Guid>("InnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InnerId");

                    b.ToTable("gacha_archives");
                });

            modelBuilder.Entity("Snap.Hutao.Model.Entity.GachaItem", b =>
                {
                    b.Property<Guid>("InnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ArchiveId")
                        .HasColumnType("TEXT");

                    b.Property<int>("GachaType")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QueryType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("InnerId");

                    b.HasIndex("ArchiveId");

                    b.ToTable("gacha_items");
                });

            modelBuilder.Entity("Snap.Hutao.Model.Entity.SettingEntry", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.ToTable("settings");
                });

            modelBuilder.Entity("Snap.Hutao.Model.Entity.User", b =>
                {
                    b.Property<Guid>("InnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cookie")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("INTEGER");

                    b.HasKey("InnerId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Snap.Hutao.Model.Entity.Achievement", b =>
                {
                    b.HasOne("Snap.Hutao.Model.Entity.AchievementArchive", "Archive")
                        .WithMany()
                        .HasForeignKey("ArchiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Archive");
                });

            modelBuilder.Entity("Snap.Hutao.Model.Entity.GachaItem", b =>
                {
                    b.HasOne("Snap.Hutao.Model.Entity.GachaArchive", "Archive")
                        .WithMany()
                        .HasForeignKey("ArchiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Archive");
                });
#pragma warning restore 612, 618
        }
    }
}
