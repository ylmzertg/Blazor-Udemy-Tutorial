using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class BlazorLibraryDBContext : DbContext
    {
        public BlazorLibraryDBContext()
        {
        }

        public BlazorLibraryDBContext(DbContextOptions<BlazorLibraryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookType> BookTypes { get; set; }
        public virtual DbSet<Button> Buttons { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationDetail> ReservationDetails { get; set; }
        public virtual DbSet<ReservationHistory> ReservationHistories { get; set; }
        public virtual DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public virtual DbSet<SexType> SexTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserPageButtonType> UserPageButtonTypes { get; set; }
        public virtual DbSet<UserPageType> UserPageTypes { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =DESKTOP-PTIBPG6\\SQLEXPRESS;database=BlazorLibraryDB;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Author");

                entity.Property(e => e.Description).HasMaxLength(750);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.Property(e => e.BookPdf).IsUnicode(false);

                entity.Property(e => e.CoverPhoto).IsUnicode(false);

                entity.Property(e => e.Summary)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookType>(entity =>
            {
                entity.ToTable("BookType");

                entity.Property(e => e.BookTypeName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(450)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Button>(entity =>
            {
                entity.ToTable("Button");

                entity.Property(e => e.ButtonName).HasMaxLength(100);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("Page");

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EPosta");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.Property(e => e.ReservationDate).HasColumnType("datetime");

                entity.Property(e => e.ReservationEndDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReservationDetail>(entity =>
            {
                entity.ToTable("ReservationDetail");
            });

            modelBuilder.Entity<ReservationHistory>(entity =>
            {
                entity.ToTable("ReservationHistory");

                entity.Property(e => e.Observation)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReservationStatus>(entity =>
            {
                entity.ToTable("ReservationStatus");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SexType>(entity =>
            {
                entity.ToTable("SexType");

                entity.Property(e => e.SexTypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserPageButtonType>(entity =>
            {
                entity.ToTable("UserPageButtonType");
            });

            modelBuilder.Entity<UserPageType>(entity =>
            {
                entity.ToTable("UserPageType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.Description)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
