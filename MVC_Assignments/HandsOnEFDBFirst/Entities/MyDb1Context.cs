using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEFDBFirst.Entities;

public partial class MyDb1Context : DbContext
{
    public MyDb1Context()
    {
    }

    public MyDb1Context(DbContextOptions<MyDb1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SANJAYDELL\\SQLEXPRESS;Initial Catalog=MyDb1;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptCode).HasName("dept_pk");

            entity.HasIndex(e => e.DeptNames, "UQ__Departme__B744FF0F59338284").IsUnique();

            entity.Property(e => e.DeptCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Dept_Code");
            entity.Property(e => e.DeptNames)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dept_Names");
        });

        modelBuilder.Entity<EmployeeDetail>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBA79340C38E2");

            entity.Property(e => e.EmpId)
                .ValueGeneratedNever()
                .HasColumnName("EmpID");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Dept_code");
            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.DeptCodeNavigation).WithMany(p => p.EmployeeDetails)
                .HasForeignKey(d => d.DeptCode)
                .HasConstraintName("employee_fko1");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Gender");

            entity.Property(e => e.Gender1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Product__C5705938016D5143");

            entity.ToTable("Product");

            entity.HasIndex(e => e.Pname, "UQ__Product__42B4608332168152").IsUnique();

            entity.Property(e => e.Pid).ValueGeneratedNever();
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
