﻿using GaspApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GaspApp.Data
{
    public class GaspDbContext : DbContext
    {
        public GaspDbContext(DbContextOptions<GaspDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<LocalizedItem> LocalizedItems { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyItem> SurveyItems { get; set; }
        public DbSet<SurveyResponse> SurveyResponses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Survey>()
                .HasMany(x => x.Items)
                .WithOne();
        }
    }
}
