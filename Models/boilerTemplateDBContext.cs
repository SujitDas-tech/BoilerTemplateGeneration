using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BoilerTemplateGeneration.Models
{
    public partial class boilerTemplateDBContext : DbContext
    {
        public boilerTemplateDBContext()
        {
        }

        public boilerTemplateDBContext(DbContextOptions<boilerTemplateDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBackEnd> TblBackEnds { get; set; } = null!;
        public virtual DbSet<TblBoilerLookUp> TblBoilerLookUps { get; set; } = null!;
        public virtual DbSet<TblFront> TblFronts { get; set; } = null!;
        public virtual DbSet<TblLogInDetail> TblLogInDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-5TIDQHJ;Initial Catalog=boilerTemplateDB;Persist Security Info=True; User Id = sujitdas; Password=Sujit@@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBackEnd>(entity =>
            {
                entity.HasKey(e => e.BackId)
                    .HasName("PK__TblBackE__5E562ADB698BC958");

                entity.ToTable("TblBackEnd");

                entity.Property(e => e.BackId).HasColumnName("BackID");

                entity.Property(e => e.BackName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBoilerLookUp>(entity =>
            {
                entity.HasKey(e => e.BoilerId)
                    .HasName("PK__TblBoile__0E939EA1F64A82F4");

                entity.ToTable("TblBoilerLookUp");

                entity.Property(e => e.BoilerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BoilerID");

                entity.Property(e => e.TechName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TechPath)
                    .HasMaxLength(800)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFront>(entity =>
            {
                entity.HasKey(e => e.FrontId)
                    .HasName("PK__TblFront__A14C4C3B8EE4F6EE");

                entity.ToTable("TblFront");

                entity.Property(e => e.FrontId).HasColumnName("FrontID");

                entity.Property(e => e.FrontName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogInDetail>(entity =>
            {
                entity.HasKey(e => e.Password)
                    .HasName("PK__TblLogIn__87909B1414D28F05");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
