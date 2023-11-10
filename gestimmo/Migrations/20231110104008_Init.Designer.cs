﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using gestimmo_WPF.Data.DAL;

#nullable disable

namespace gestimmo_WPF.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20231110104008_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("gestimmo_WPF.Bien", b =>
                {
                    b.Property<int>("BienId")
                        .HasColumnType("integer");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Surface")
                        .HasColumnType("double precision");

                    b.Property<double>("Valeur")
                        .HasColumnType("double precision");

                    b.HasKey("BienId");

                    b.ToTable("Biens");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("gestimmo_WPF.Contrat", b =>
                {
                    b.Property<int>("ContratId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ContratId"));

                    b.Property<int>("BienId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Loyer")
                        .HasColumnType("double precision");

                    b.HasKey("ContratId");

                    b.HasIndex("BienId");

                    b.ToTable("Bails");
                });

            modelBuilder.Entity("gestimmo_WPF.Intervention", b =>
                {
                    b.Property<int>("InterventionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InterventionId"));

                    b.Property<int>("BienId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("MontantTTC")
                        .HasColumnType("double precision");

                    b.Property<int>("PrestataireId")
                        .HasColumnType("integer");

                    b.HasKey("InterventionId");

                    b.HasIndex("BienId");

                    b.HasIndex("PrestataireId");

                    b.ToTable("Interventions");
                });

            modelBuilder.Entity("gestimmo_WPF.Locataire", b =>
                {
                    b.Property<int>("LocataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LocataireId"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int>("BailContratId")
                        .HasColumnType("integer");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LocataireId");

                    b.HasIndex("BailContratId");

                    b.ToTable("Locataires");
                });

            modelBuilder.Entity("gestimmo_WPF.Prestataire", b =>
                {
                    b.Property<int>("PrestataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PrestataireId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RaisonSociale")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PrestataireId");

                    b.ToTable("Prestataires");
                });

            modelBuilder.Entity("gestimmo_WPF.Pret", b =>
                {
                    b.Property<int>("PretId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PretId"));

                    b.Property<double>("Apport")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duree")
                        .HasColumnType("integer");

                    b.Property<double>("MontantPret")
                        .HasColumnType("double precision");

                    b.Property<double>("TauxInteret")
                        .HasColumnType("double precision");

                    b.HasKey("PretId");

                    b.ToTable("Prets");
                });

            modelBuilder.Entity("gestimmo_WPF.Box", b =>
                {
                    b.HasBaseType("gestimmo_WPF.Bien");

                    b.ToTable("Box", (string)null);
                });

            modelBuilder.Entity("gestimmo_WPF.Habitable", b =>
                {
                    b.HasBaseType("gestimmo_WPF.Bien");

                    b.Property<bool>("Cave")
                        .HasColumnType("boolean");

                    b.Property<int>("HabitableId")
                        .HasColumnType("integer");

                    b.Property<int>("NbChambre")
                        .HasColumnType("integer");

                    b.Property<int>("NbPiece")
                        .HasColumnType("integer");

                    b.Property<bool>("Parking")
                        .HasColumnType("boolean");

                    b.ToTable("Habitable", (string)null);
                });

            modelBuilder.Entity("gestimmo_WPF.Appartement", b =>
                {
                    b.HasBaseType("gestimmo_WPF.Habitable");

                    b.Property<int>("AppartementId")
                        .HasColumnType("integer");

                    b.Property<bool>("Ascenseur")
                        .HasColumnType("boolean");

                    b.Property<bool>("ChauffageCommun")
                        .HasColumnType("boolean");

                    b.Property<int>("Etage")
                        .HasColumnType("integer");

                    b.ToTable("Appartement", (string)null);
                });

            modelBuilder.Entity("gestimmo_WPF.Maison", b =>
                {
                    b.HasBaseType("gestimmo_WPF.Habitable");

                    b.ToTable("Maison", (string)null);
                });

            modelBuilder.Entity("gestimmo_WPF.Bien", b =>
                {
                    b.HasOne("gestimmo_WPF.Pret", "Pret")
                        .WithOne("Bien")
                        .HasForeignKey("gestimmo_WPF.Bien", "BienId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pret");
                });

            modelBuilder.Entity("gestimmo_WPF.Contrat", b =>
                {
                    b.HasOne("gestimmo_WPF.Bien", "Bien")
                        .WithMany("Contrats")
                        .HasForeignKey("BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bien");
                });

            modelBuilder.Entity("gestimmo_WPF.Intervention", b =>
                {
                    b.HasOne("gestimmo_WPF.Bien", "Bien")
                        .WithMany("Interventions")
                        .HasForeignKey("BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gestimmo_WPF.Prestataire", "Prestataire")
                        .WithMany("Interventions")
                        .HasForeignKey("PrestataireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bien");

                    b.Navigation("Prestataire");
                });

            modelBuilder.Entity("gestimmo_WPF.Locataire", b =>
                {
                    b.HasOne("gestimmo_WPF.Contrat", "Bail")
                        .WithMany("Locataires")
                        .HasForeignKey("BailContratId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bail");
                });

            modelBuilder.Entity("gestimmo_WPF.Box", b =>
                {
                    b.HasOne("gestimmo_WPF.Bien", null)
                        .WithOne()
                        .HasForeignKey("gestimmo_WPF.Box", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gestimmo_WPF.Habitable", b =>
                {
                    b.HasOne("gestimmo_WPF.Bien", null)
                        .WithOne()
                        .HasForeignKey("gestimmo_WPF.Habitable", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gestimmo_WPF.Appartement", b =>
                {
                    b.HasOne("gestimmo_WPF.Habitable", null)
                        .WithOne()
                        .HasForeignKey("gestimmo_WPF.Appartement", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gestimmo_WPF.Maison", b =>
                {
                    b.HasOne("gestimmo_WPF.Habitable", null)
                        .WithOne()
                        .HasForeignKey("gestimmo_WPF.Maison", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gestimmo_WPF.Bien", b =>
                {
                    b.Navigation("Contrats");

                    b.Navigation("Interventions");
                });

            modelBuilder.Entity("gestimmo_WPF.Contrat", b =>
                {
                    b.Navigation("Locataires");
                });

            modelBuilder.Entity("gestimmo_WPF.Prestataire", b =>
                {
                    b.Navigation("Interventions");
                });

            modelBuilder.Entity("gestimmo_WPF.Pret", b =>
                {
                    b.Navigation("Bien")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
