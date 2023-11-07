using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Common;
using P01_StudentSystem.Data.Models;
using System.Net;

namespace P01_StudentSystem.Data;

public class StudentSystemContext : DbContext
{
    public StudentSystemContext()
    {

    }

    public StudentSystemContext(DbContextOptions options) : base(options) { }

    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Homework> Homeworks { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<StudentCourse> StudentsCourses { get; set; }
    public virtual DbSet<Resource> Resources { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
        }
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<StudentCourse>()
        .HasKey(sc => new {sc.StudentId, sc.CourseId});
    }
    
}
