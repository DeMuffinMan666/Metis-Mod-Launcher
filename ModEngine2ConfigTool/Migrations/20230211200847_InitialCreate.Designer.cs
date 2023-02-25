﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModEngine2ConfigTool.Models;

#nullable disable

namespace ModEngine2ConfigTool.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230211200847_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("DllProfile", b =>
                {
                    b.Property<Guid>("DllsDllId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProfilesProfileId")
                        .HasColumnType("TEXT");

                    b.HasKey("DllsDllId", "ProfilesProfileId");

                    b.HasIndex("ProfilesProfileId");

                    b.ToTable("DllProfile");
                });

            modelBuilder.Entity("ModEngine2ConfigTool.Models.Dll", b =>
                {
                    b.Property<Guid>("DllId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Added")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DllId");

                    b.ToTable("Dlls");
                });

            modelBuilder.Entity("ModEngine2ConfigTool.Models.Mod", b =>
                {
                    b.Property<Guid>("ModId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Added")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("FolderPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ModId");

                    b.ToTable("Mods");
                });

            modelBuilder.Entity("ModEngine2ConfigTool.Models.Profile", b =>
                {
                    b.Property<Guid>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastPlayed")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("UseDebugMode")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UseSaveManager")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UseScyllaHide")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProfileId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("ModProfile", b =>
                {
                    b.Property<Guid>("ModsModId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProfilesProfileId")
                        .HasColumnType("TEXT");

                    b.HasKey("ModsModId", "ProfilesProfileId");

                    b.HasIndex("ProfilesProfileId");

                    b.ToTable("ModProfile");
                });

            modelBuilder.Entity("DllProfile", b =>
                {
                    b.HasOne("ModEngine2ConfigTool.Models.Dll", null)
                        .WithMany()
                        .HasForeignKey("DllsDllId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModEngine2ConfigTool.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ModProfile", b =>
                {
                    b.HasOne("ModEngine2ConfigTool.Models.Mod", null)
                        .WithMany()
                        .HasForeignKey("ModsModId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModEngine2ConfigTool.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
