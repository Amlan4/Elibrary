using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Elibrary3.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ElAdmistratorMsts> ElAdmistratorMsts { get; set; }
        public virtual DbSet<ElStudentMsts> ElStudentMsts { get; set; }
        public virtual DbSet<ElTeacherMsts> ElTeacherMsts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle(" License Key=vEyr8GdnIarOKlEHQKxi+4E0HlXN85PVGHI096M18fHO05syciZT/8xvOeNbTwuMbqdZkRZ1qbdPjO13mrnBnlMUyskKr9qbBNMTzJAp5+R858T7YUZaTY5rodcDl7pDutJBeuYiwHG+xtXnywKMPX+9u82fR1AMT9EailpEiBp1OAn6IbJ55eXY15+rsAfDDwUuIv/js610S6cy9vLt37IL4PcZ8Wx/MrQlA38Z+kEH9Wztcv+NSWFVRz2wnVRDtIowaySSKk30sA+MBbg2IIUI+/MgDUp6w53NCxQSsuM=; User Id=iusf;Password=iusf_dev;SERVICE NAME=ifppdbdev;Direct=true;Data Source=iffcoexadr-92rdq-scan.drhyddbcltsn01.drhydebsprodvcn.oraclevcn.com:1521/ifppdbdev.drhyddbcltsn01.drhydebsprodvcn.oraclevcn.com;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElAdmistratorMsts>(entity =>
            {
                entity.HasKey(e => e.IdNo);

                entity.ToTable("EL_ADMISTRATOR_MSTS", "IUSF");

                entity.HasIndex(e => e.IdNo)
                    .HasName("EL_ADMINISTRATOR_MSTS_PK")
                    .IsUnique();

                entity.Property(e => e.IdNo)
                    .HasColumnName("ID_NO")
                    .HasColumnType("varchar2")
                    .HasMaxLength(8);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasColumnType("varchar2")
                    .HasMaxLength(8);

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            });

            modelBuilder.Entity<ElStudentMsts>(entity =>
            {
                entity.HasKey(e => e.IdNo);

                entity.ToTable("EL_STUDENT_MSTS", "IUSF");

                entity.HasIndex(e => e.IdNo)
                    .HasName("EL_STUDENT_MSTS_PK")
                    .IsUnique();

                entity.Property(e => e.IdNo)
                    .HasColumnName("ID_NO")
                    .HasColumnType("varchar2")
                    .HasMaxLength(8);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasColumnType("varchar2")
                    .HasMaxLength(8);

                entity.Property(e => e.Phone).HasColumnName("PHONE");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Email).HasColumnName("EMAIL");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.SlNo).HasColumnName("SL_NO");
            });

            modelBuilder.Entity<ElTeacherMsts>(entity =>
            {
                entity.HasKey(e => e.IdNo);

                entity.ToTable("EL_TEACHER_MSTS", "IUSF");

                entity.HasIndex(e => e.IdNo)
                    .HasName("EL_TEACHER_MSTS_PK")
                    .IsUnique();

                entity.Property(e => e.IdNo)
                    .HasColumnName("ID_NO")
                    .HasColumnType("varchar2")
                    .HasMaxLength(8);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasColumnType("varchar2")
                    .HasMaxLength(8);

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            });
        }
    }
}
