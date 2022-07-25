using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FIFAPI.Models
{
    public partial class FifaAPIdbContext : DbContext
    {
        public FifaAPIdbContext()
        {
        }

        public FifaAPIdbContext(DbContextOptions<FifaAPIdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.PlayerName, "IX_Players")
                    .IsUnique();

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(64)
                    .IsFixedLength();

                entity.Property(e => e.PlayerPosition)
                    .HasMaxLength(64)
                    .IsFixedLength();

                entity.Property(e => e.PlayerTeamId).HasColumnName("PlayerTeamID");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasIndex(e => e.TeamName, "IX_Teams")
                    .IsUnique();

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.Country)
                    .HasMaxLength(64)
                    .IsFixedLength();

                entity.Property(e => e.TeamName)
                    .HasMaxLength(64)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
