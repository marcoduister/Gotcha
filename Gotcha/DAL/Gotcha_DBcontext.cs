using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gotcha.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gotcha.DAL
{
    class Gotcha_DBcontext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<RuleSet> RuleSets { get; set; }
        public DbSet<PlayerSet> PlayerSets { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<WordSet> WordSets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("server=.;database=Gotcha_DEV;trusted_connection=true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WordSet>().HasMany(p => p.Words);
            modelBuilder.Entity<RuleSet>().HasMany(p => p.Rules);

            modelBuilder.Entity<Word>().HasOne(p => p.User).WithMany(p => p.Word).HasForeignKey(f => f.Maker_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<WordSet>().HasOne(p => p.User).WithMany(p => p.WordSets).HasForeignKey(f => f.Maker_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Rule>().HasOne(p => p.User).WithMany(p => p.Rules).HasForeignKey(f => f.Maker_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<RuleSet>().HasOne(p => p.User).WithMany(p => p.RuleSets).HasForeignKey(f => f.Maker_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Game>().HasOne(p => p.User).WithMany(p => p.Games).HasForeignKey(f => f.Maker_Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GameType>().HasOne(p => p.User).WithMany(p => p.GameTypes).HasForeignKey(f => f.Maker_Id).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WordSet>().HasMany(p => p.Games).WithOne(p => p.WordSet).HasForeignKey(f => f.WordSet_Id);
            modelBuilder.Entity<RuleSet>().HasMany(p => p.Games).WithOne(p => p.RuleSet).HasForeignKey(f => f.RuleSet_Id);
            modelBuilder.Entity<GameType>().HasMany(p => p.Games).WithOne(p => p.GameType).HasForeignKey(f => f.GameType_Id);
            modelBuilder.Entity<Game>().HasMany(p => p.PlayerSets).WithOne(p => p.Game).HasForeignKey(f => f.Game_Id);
        }
    }
}