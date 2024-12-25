using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APINetCoreCrudOperation.Models;

public partial class CfnewContext : DbContext
{
    public CfnewContext()
    {
    }

    public CfnewContext(DbContextOptions<CfnewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        { 
        
        
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.StudentGender)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Student_Gender");
            entity.Property(e => e.StudentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Student_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
