﻿// <auto-generated />
using System;
using EFVersenyDataAccessTest.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFVersenyDataAccessTest.Migrations
{
    [DbContext(typeof(VersenyContext))]
    [Migration("20201216203604_SeedTestData1")]
    partial class SeedTestData1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.Jatek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Jatekok");
                });

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.JatekosNev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("JatekId")
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ProfilId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JatekId");

                    b.HasIndex("ProfilId");

                    b.ToTable("JatekosNevek");
                });

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.Profil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailCim")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KeresztNev")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Nem")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("ProfilNev")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("RegisztracioIdeje")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("SzuletesiIdo")
                        .HasColumnType("datetime");

                    b.Property<string>("VezetekNev")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Profilok");
                });

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.JatekosNev", b =>
                {
                    b.HasOne("EFVersenyDataAccessTest.Models.Jatek", "Jatek")
                        .WithMany()
                        .HasForeignKey("JatekId");

                    b.HasOne("EFVersenyDataAccessTest.Models.Profil", null)
                        .WithMany("JatekosNevek")
                        .HasForeignKey("ProfilId");
                });
#pragma warning restore 612, 618
        }
    }
}
