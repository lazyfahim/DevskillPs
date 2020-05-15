using Microsoft.EntityFrameworkCore;

namespace DevSkillSystem.FrameWork
{
    public class FrameWorkContext:DbContext
    {
        private string _connectionStringName;
        private string _migrationAssemblyName;
        
        public DbSet<Transaction> Transactions { get; set; }
        
        public FrameWorkContext(string connectionStringName, string migrationAssemblyName)
        {
            _connectionStringName = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Transaction>()
                .Property(t => t.TrxType)
                .HasConversion<string>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionStringName,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}