using Day02_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02_MVC.Data
{
    public class SystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MAHMOUDAKL\\SQL22;Database=MVC_Learn;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudCrsRes>()
                         .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudCrsRes>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudCrs)
                .HasForeignKey(sc => sc.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudCrsRes>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudCrs)
                .HasForeignKey(sc => sc.CourseId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Teacher>()
                        .HasOne(t => t.Department)
                        .WithMany(d => d.Teachers)
                        .HasForeignKey(t => t.DeptId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Teacher>()
                        .HasOne(t => t.Course)
                        .WithMany(c => c.Teachers)
                        .HasForeignKey(t => t.CourseId)
                        .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Teacher> Teachers { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.StudCrsRes> StudCrs { get; set; }

    }
}