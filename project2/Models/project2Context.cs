using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace project2.Models
{
    public partial class project2Context : DbContext
    {

        public project2Context(DbContextOptions<project2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Money> Money { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=IDEA-PC\\SQLEXPRESS;Database=project2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Education>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_educationId");

                entity.Property(e => e.Education1).HasColumnName("Education");

                entity.Property(e => e.EducationField)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber)
                    .HasName("PK_mployee");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.Attrition)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.BusinessTravel)
                    .IsRequired()
                    .HasMaxLength(17);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Over18)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BusinessTravel)
                    .IsRequired()
                    .HasMaxLength(17);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(22);

                entity.Property(e => e.JobRole)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.OverTime)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Money>(entity =>
            {
                entity.HasNoKey();
            });

            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
