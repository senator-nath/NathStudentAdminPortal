using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NathStudentAdminPortal.Model;

namespace NathStudentAdminPortal.Data
{
    public class StudentDbContext : IdentityDbContext<User>
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
       : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<LGA> LGAs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize relationships and configurations
            builder.Entity<Student>()
       .HasOne(s => s.Class)
       .WithMany(c => c.Students)
       .HasForeignKey(s => s.ClassId)
       .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            builder.Entity<Teacher>()
                .HasOne(t => t.Class)
                .WithMany(c => c.Teachers)
                .HasForeignKey(t => t.ClassId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            builder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            builder.Entity<Class>()
        .HasKey(c => c.Id);


        }
    }
}
