using Microsoft.EntityFrameworkCore;

namespace DevSkillSystem.FrameWork
{
    public class FrameWorkContext:DbContext
    {
        private string _connectionStringName;
        private string _migrationAssemblyName;
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; } 
        
        public FrameWorkContext(string connectionStringName, string migrationAssemblyName)
        {
            _connectionStringName = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasKey(gr => new {gr.StudentId, gr.SubjectId});
            base.OnModelCreating(modelBuilder);
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