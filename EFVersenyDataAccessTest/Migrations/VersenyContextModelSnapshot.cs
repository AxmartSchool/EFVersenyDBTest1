﻿// <auto-generated />
using System;
using EFVersenyDataAccessTest.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFVersenyDataAccessTest.Migrations
{
    [DbContext(typeof(VersenyContext))]
    partial class VersenyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.Meccs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte>("BestOf")
                        .HasColumnType("tinyint");

                    b.Property<int?>("KihivoId")
                        .HasColumnType("int");

                    b.Property<byte>("KihivoPontszam")
                        .HasColumnType("tinyint");

                    b.Property<int?>("KihivottId")
                        .HasColumnType("int");

                    b.Property<byte>("KihivottPontszam")
                        .HasColumnType("tinyint");

                    b.Property<string>("Statusz")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("VersenyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KihivoId");

                    b.HasIndex("KihivottId");

                    b.HasIndex("VersenyId");

                    b.ToTable("Meccsek");
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

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.Resztvevo", b =>
                {
                    b.Property<int>("ProfilId")
                        .HasColumnType("int");

                    b.Property<int>("VersenyId")
                        .HasColumnType("int");

                    b.Property<int>("Seed")
                        .HasColumnType("int");

                    b.Property<string>("Statusz")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ProfilId", "VersenyId");

                    b.HasIndex("VersenyId");

                    b.ToTable("Resztvevok");
                });

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.Verseny", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("JatekId")
                        .HasColumnType("int");

                    b.Property<string>("JatekMod")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("KezdesIdeje")
                        .HasColumnType("datetime");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Statusz")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Szabalyzat")
                        .HasColumnType("mediumtext");

                    b.HasKey("Id");

                    b.HasIndex("JatekId");

                    b.ToTable("Versenyek");
                });

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.JatekosNev", b =>
                {
                    b.HasOne("EFVersenyDataAccessTest.Models.Jatek", "Jatek")
                        .WithMany()
                        .HasForeignKey("JatekId");

                    b.HasOne("EFVersenyDataAccessTest.Models.Profil", "Profil")
                        .WithMany("JatekosNevek")
                        .HasForeignKey("ProfilId");
                });

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.Meccs", b =>
                {
                    b.HasOne("EFVersenyDataAccessTest.Models.Profil", "Kihivo")
                        .WithMany()
                        .HasForeignKey("KihivoId");

                    b.HasOne("EFVersenyDataAccessTest.Models.Profil", "Kihivott")
                        .WithMany()
                        .HasForeignKey("KihivottId");

                    b.HasOne("EFVersenyDataAccessTest.Models.Verseny", "Verseny")
                        .WithMany("Meccsek")
                        .HasForeignKey("VersenyId");
                });

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.Resztvevo", b =>
                {
                    b.HasOne("EFVersenyDataAccessTest.Models.Profil", "Profil")
                        .WithMany()
                        .HasForeignKey("ProfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFVersenyDataAccessTest.Models.Verseny", "Verseny")
                        .WithMany("Resztvevok")
                        .HasForeignKey("VersenyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFVersenyDataAccessTest.Models.Verseny", b =>
                {
                    b.HasOne("EFVersenyDataAccessTest.Models.Jatek", "Jatek")
                        .WithMany()
                        .HasForeignKey("JatekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
