using System.Collections.Generic;
using gestimmo_WPF.Data.DAL;
using gestimmo_WPF.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;


namespace gestimmo_WPF.Data.DAL
{

    public class BloggingContext : DbContext
    {
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Contrat> Bails { get; set; }
        public DbSet<Bien> Biens { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Pret> Prets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=gestimmo;Username=postgres;Password=root");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pret>()
                .HasOne(p => p.Bien)
                .WithOne(b => b.Pret)
                .HasForeignKey<Bien>(b => b.BienId) // Clé étrangère dans Bien pour référencer Pret
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Habitable>().ToTable("Habitable");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Appartement");
         

        }









    }
}