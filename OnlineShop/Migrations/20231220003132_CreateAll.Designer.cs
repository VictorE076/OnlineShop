﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Data;

#nullable disable

namespace OnlineShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231220003132_CreateAll")]
    partial class CreateAll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineShop.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorii");
                });

            modelBuilder.Entity("OnlineShop.Models.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Stare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UtilizatorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Valoare")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UtilizatorId");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("OnlineShop.Models.Exemplar", b =>
                {
                    b.Property<int>("Id_Produs")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Comanda")
                        .HasColumnType("int");

                    b.Property<int?>("ComandaId")
                        .HasColumnType("int");

                    b.Property<int>("Numar_Produs")
                        .HasColumnType("int");

                    b.Property<string>("Stare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Produs", "Id_Comanda");

                    b.HasIndex("ComandaId");

                    b.ToTable("Exemplare");
                });

            modelBuilder.Entity("OnlineShop.Models.Produs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_Categorie")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Poza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Pret")
                        .HasColumnType("real");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("OnlineShop.Models.Review", b =>
                {
                    b.Property<int>("UtilizatorId")
                        .HasColumnType("int");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.Property<string>("Continut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UtilizatorId", "ProdusId");

                    b.ToTable("Reviewuri");
                });

            modelBuilder.Entity("OnlineShop.Models.Utilizator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasMaxLength(48)
                        .HasColumnType("nvarchar(48)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilizatori");
                });

            modelBuilder.Entity("OnlineShop.Models.Comanda", b =>
                {
                    b.HasOne("OnlineShop.Models.Utilizator", "Utilizator")
                        .WithMany()
                        .HasForeignKey("UtilizatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizator");
                });

            modelBuilder.Entity("OnlineShop.Models.Exemplar", b =>
                {
                    b.HasOne("OnlineShop.Models.Comanda", "Comanda")
                        .WithMany()
                        .HasForeignKey("ComandaId");

                    b.Navigation("Comanda");
                });

            modelBuilder.Entity("OnlineShop.Models.Produs", b =>
                {
                    b.HasOne("OnlineShop.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });
#pragma warning restore 612, 618
        }
    }
}
