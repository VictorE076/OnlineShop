﻿using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Exemplar>()
                .HasKey(ex => new { ex.Id_Produs, ex.Id_Comanda });

			modelBuilder.Entity<Review>()
				.HasKey(rev => new { rev.UtilizatorId, rev.ProdusId });
		}

        public DbSet<Utilizator> Utilizatori { get; set; }
		public DbSet<Review> Reviewuri { get; set; }
		public DbSet<Produs> Produse { get; set; }
		public DbSet<Exemplar> Exemplare { get; set; }
		public DbSet<Categorie> Categorii { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
    }
}
