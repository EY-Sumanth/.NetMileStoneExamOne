using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MileStone1_Feb13.Models
{
    public partial class CollegeLibraryContext : DbContext
    {
        public CollegeLibraryContext()
        {
        }

        public CollegeLibraryContext(DbContextOptions<CollegeLibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TAuthorDetail> TAuthorDetails { get; set; } = null!;
        public virtual DbSet<TBookDetail> TBookDetails { get; set; } = null!;
        public virtual DbSet<TBorrowDetail> TBorrowDetails { get; set; } = null!;
        public virtual DbSet<TStudentDetail> TStudentDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=IN3238387W1\\SQLEXPRESS;Initial Catalog=CollegeLibrary;Trusted_Connection=True;TrustServerCertificate=True;database=CollegeLibrary");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAuthorDetail>(entity =>
            {
                entity.HasKey(e => e.AuthorId);

                entity.ToTable("T_AuthorDetails");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBookDetail>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.ToTable("T_BookDetails");

                entity.Property(e => e.BookName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBorrowDetail>(entity =>
            {
                entity.HasKey(e => e.BorrowId);

                entity.ToTable("T_BorrowDetails");

                entity.Property(e => e.BorrowDate).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");
            });

            modelBuilder.Entity<TStudentDetail>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("T_StudentDetails");

                entity.Property(e => e.StudentGender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
