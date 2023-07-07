using Microsoft.EntityFrameworkCore;

namespace WebAPIwithEFCodeFirst.Data
{
    public class StudentDataContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentDataContext(DbContextOptions<StudentDataContext> dbContextOptions):base(dbContextOptions)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
