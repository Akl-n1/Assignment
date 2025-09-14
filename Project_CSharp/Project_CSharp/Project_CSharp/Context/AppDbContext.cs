using Microsoft.EntityFrameworkCore;
using Project_CSharp.Models;

namespace ExaminationSystem
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Instructor> Instructors { get; set; } = null!;
        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;
        public DbSet<Exam> Exams { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<Answer> Answers { get; set; } = null!;
        public DbSet<ExamResult> ExamResults { get; set; } = null!;

        //public AppDbContext() { }

        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                // Default SQL Server connection (used only if no options provided)
                options.UseSqlServer("Server=MAHMOUDAKL\\SQL22;Database=ExaminationSystemDB;Integrated Security=True;TrustServerCertificate=True;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                .HasDiscriminator<string>("QuestionType")
                .HasValue<TrueFalseQuestion>("TrueFalse")
                .HasValue<ChooseOneQuestion>("ChooseOne")
                .HasValue<ChooseAllQuestion>("ChooseAll");

            modelBuilder.Entity<Exam>()
                .HasDiscriminator<string>("ExamType")
                .HasValue<PracticeExam>("Practice")
                .HasValue<FinalExam>("Final");

            modelBuilder.Entity<User>()
                .HasDiscriminator(u => u.Role)
                .HasValue<Student>(UserRole.Student)
                .HasValue<Instructor>(UserRole.Instructor)
                .HasValue<Admin>(UserRole.Admin);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Questions)
                .WithOne(q => q.Exam)
                .HasForeignKey(q => q.ExamId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne(a => a.Question)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>();
        }
    }
}
