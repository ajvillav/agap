﻿using Agap.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agap.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<Fertilizer> Fertilizers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Fertilizer>().HasIndex(fertilizer => new { fertilizer.Name, fertilizer.Brand }).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(country => country.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex(state => new { state.CountryId, state.Name }).IsUnique();
            modelBuilder.Entity<City>().HasIndex(city => new { city.StateId, city.Name }).IsUnique();
        }
    }
}
