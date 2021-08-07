using domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace domain
{
    public class OBotFactoryContext : DbContext
    {
        public OBotFactoryContext(DbContextOptions<OBotFactoryContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MS> MSs { get; set; }
        public DbSet<SheetCapabilty> SheetCapabilties { get; set; }
        public DbSet<Capability> Capabilities { get; set; }
        public DbSet<SheetSkill> SheetSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SheetGenericAdvantage> SheetGenericAdvantages { get; set; }
        public DbSet<GenericAdvantage> GenericAdvantages { get; set; }
        public DbSet<SheetDisadvantage> SheetDisadvantages { get; set; }
        public DbSet<Disadvantage> Disadvantages { get; set; }
        public DbSet<SheetWeapon> SheetWeapons { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<SheetArmor> SheetArmors { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<SheetItem> SheetItems { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
