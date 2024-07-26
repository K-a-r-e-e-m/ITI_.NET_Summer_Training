﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

public partial class Company_SDContext : DbContext
{
    public Company_SDContext()
    {
    }

    public Company_SDContext(DbContextOptions<Company_SDContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dependent> Dependents { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Works_for> Works_fors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=KAREEM\\SQLEXPRESS;Initial Catalog=Company_SD;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.Dnum).ValueGeneratedNever();

            entity.HasOne(d => d.MGRSSNNavigation).WithMany(p => p.Departments).HasConstraintName("FK_Departments_Employee");
        });

        modelBuilder.Entity<Dependent>(entity =>
        {
            entity.HasOne(d => d.ESSNNavigation).WithMany(p => p.Dependents).HasConstraintName("FK_Dependent_Employee");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.SSN).ValueGeneratedNever();

            entity.HasOne(d => d.DnoNavigation).WithMany(p => p.Employees).HasConstraintName("FK_Employee_Departments");

            entity.HasOne(d => d.SuperssnNavigation).WithMany(p => p.InverseSuperssnNavigation).HasConstraintName("FK_Employee_Employee");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.Property(e => e.Pnumber).ValueGeneratedNever();

            entity.HasOne(d => d.DnumNavigation).WithMany(p => p.Projects).HasConstraintName("FK_Project_Departments");
        });

        modelBuilder.Entity<Works_for>(entity =>
        {
            entity.HasOne(d => d.ESSnNavigation).WithMany(p => p.Works_fors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Works_for_Employee");

            entity.HasOne(d => d.PnoNavigation).WithMany(p => p.Works_fors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Works_for_Project");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}