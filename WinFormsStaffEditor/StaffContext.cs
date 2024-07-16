using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace WinFormsStaffEditor;

public partial class StaffContext : DbContext
{
    public StaffContext()
    {
    }

    public StaffContext(DbContextOptions<StaffContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Staff> Staff { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=root;database=staff", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.24-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("staff");

            entity.HasIndex(e => e.Snils, "SNILS").IsUnique();

            entity.HasIndex(e => e.Id, "id");

            entity.Property(e => e.Id)
                .HasComment("уникальный id в базе")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.BirthDate)
                .HasComment("Дата рождения")
                .HasColumnName("birthDate");
            entity.Property(e => e.EmploymentDate)
                .HasComment("Дата приема на работу")
                .HasColumnName("employmentDate");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("Имя")
                .HasColumnName("name");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(100)
                .HasComment("Отчество")
                .HasColumnName("patronymic");
            entity.Property(e => e.Position)
                .HasMaxLength(100)
                .HasDefaultValueSql("Стажер")
                .HasComment("Должность")
                .HasColumnName("position");
            entity.Property(e => e.Snils)
                .HasMaxLength(11)
                .HasComment("СНИЛС сотрудника(уникален)")
                .HasColumnName("snils");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .HasComment("Фамилия")
                .HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
