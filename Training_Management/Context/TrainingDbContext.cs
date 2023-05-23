using Microsoft.EntityFrameworkCore;
using Training_Management.Models;

namespace Training_Management.Context
{
    public class TrainingDbContext : DbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options)
        {

        }

        public TrainingDbContext()
        {
        }
        public DbSet<User> Users{ get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Batch> Batches { get; set; }

        public DbSet<Training_Management.Models.BatchViewModel>? BatchViewModel { get; set; }





    }
}
