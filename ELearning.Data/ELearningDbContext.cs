using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;

namespace ELearning.Data
{
    public class ELearningDbContext : DbContext
    {
        public ELearningDbContext(DbContextOptions<ELearningDbContext> options) : base(options) { }

        DbSet<User> Users { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Enrollment> Enrollments { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<Level> Levels { get; set; }
        DbSet<PaymentMethod> PaymentMethods { get; set; }
        DbSet<RefundRequest> RefundRequests { get; set; }
        DbSet<FavoriteCourse> FavoriteCourses { get; set; }
        DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>(e =>
            {
                e.ToTable("Enrollments")
                    .HasKey(e => e.EnrollmentId);
                e.HasOne(e => e.Student)
                    .WithMany(u => u.Enrollments)
                    .HasForeignKey(e => e.StudentId)
                    .OnDelete(DeleteBehavior.NoAction);
                e.HasOne(e => e.Course)
                    .WithMany(c => c.Enrollments)
                    .HasForeignKey(e => e.CourseId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("Users").HasKey(u => u.UserId);
                e.HasMany(u => u.FavoriteCourses).WithOne(fc => fc.User).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.NoAction);
                e.HasMany(u => u.UserRoles).WithOne(u => u.User).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Course>(e =>
            {
                e.ToTable("Courses").HasKey(c => c.CourseId);
                e.Property(c => c.Price).HasColumnType("decimal(18,2)");
                e.Property(c => c.SalePrice).HasColumnType("decimal(18,2)");
                e.HasMany(u => u.FavoriteCourses).WithOne(fc => fc.Course).HasForeignKey(u => u.CourseId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Payment>(e =>
            {
                e.ToTable("Payments").HasKey(p => p.PaymentId);
                e.Property(p => p.Amount).HasColumnType("decimal(18,2)");

            });

            modelBuilder.Entity<RefundRequest>(e =>
            {
                e.ToTable("RefundRequests").HasKey(r => r.RefundId);
                e.Property(r => r.RefundAmount).HasColumnType("decimal(18,2)");

            });

            modelBuilder.Entity<FavoriteCourse>(e =>
            {
                e.ToTable("FavoriteCourses").HasKey(fc => new { fc.UserId, fc.CourseId });
            });

            modelBuilder.Entity<UserRole>(e =>
            {
                e.ToTable("UserRoles").HasKey(ur => new { ur.UserId, ur.RoleId });
            });

            modelBuilder.Entity<Role>(e =>
            {
                e.ToTable("Roles").HasKey(r => r.RoleId);
                e.HasMany(u => u.UserRoles).WithOne(u => u.Role).HasForeignKey(r => r.RoleId).OnDelete(DeleteBehavior.NoAction);
            });
            
        }

    }
}
