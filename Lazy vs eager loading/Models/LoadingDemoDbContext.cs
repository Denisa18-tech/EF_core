using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentCourseLoadingDemo.Models;

public partial class LoadingDemoDbContext : DbContext
{
    public LoadingDemoDbContext()
    {
    }

    public LoadingDemoDbContext(DbContextOptions<LoadingDemoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=LoadingDemoDb;Username=postgres;Password=Welcome@123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courses_pkey");

            entity.ToTable("courses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Studentid).HasColumnName("studentid");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");

            entity.HasOne(d => d.Student).WithMany(p => p.Courses)
                .HasForeignKey(d => d.Studentid)
                .HasConstraintName("courses_studentid_fkey");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("students_pkey");

            entity.ToTable("students");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
