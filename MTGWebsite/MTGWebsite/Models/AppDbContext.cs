using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Models
{
    public class AppDbContext : DbContext
    {
        //   F i e l d s   &   P r o p e r t i e s

        public DbSet<Card> Cards    { get; set; }
        public DbSet<Set>  Sets     { get; set; } 

        //   C o n s t r u c t o r s

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //   M e t h o d s

        protected override void OnModelCreating
   (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Card>().HasData
               (new Card
               {
                   CardId = 1,
                   Name = "Academic Probation",
                   ManaCost = "1 Colorless, 1 White",
                   ConvertedMana = 2,
                   Type = "Sorcery - Lesson",
                   CardText = "Choose one - ... ",
                   Expansion = "Strixhaven: School of Mages",
                   FlavorText = "None",
                   Rarity = "Rare",
                   CardNumber = 7,
                   Image = "https://media.wizards.com/2021/stx/en_yh4p4W4O4x.png"
               });

            modelBuilder.Entity<Card>().HasData
               (new Card
               {
                   CardId = 2,
                   Name = "Ageless Guardian",
                   ManaCost = "1 Colorless, 1 White",
                   ConvertedMana = 2,
                   Type = "Creature - Spirit Soldier",
                   CardText = "None",
                   Expansion = "Strixhaven: School of Mages",
                   FlavorText = "Ancient ruins...",
                   Rarity = "Uncommon",
                   CardNumber = 8,
                   Image = "https://media.wizards.com/2021/stx/en_v5m1B5aTSo.png"

               });

            modelBuilder.Entity<Card>().HasData
               (new Card
               {
                   CardId = 3,
                   Name = "Beaming Defiance",
                   ManaCost = "1 Colorless, 1 White",
                   ConvertedMana = 2,
                   Type = "Instant",
                   CardText = "Target creature you...",
                   Expansion = "Strixhaven: School of Mages",
                   FlavorText = "I've lived too...",
                   Rarity = "Common",
                   CardNumber = 9,
                   Image = "https://media.wizards.com/2021/stx/en_2B1ejCfSFx.png"
               });
        }
    }
}