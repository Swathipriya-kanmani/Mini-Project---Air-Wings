using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AirlinesProject.Models
{
    public partial class WebsiteAirlineContext : DbContext
    {
        public WebsiteAirlineContext()
        {
        }

        public WebsiteAirlineContext(DbContextOptions<WebsiteAirlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminLogin> AdminLogins { get; set; } = null!;
        public virtual DbSet<AirplaneInfo> AirplaneInfos { get; set; } = null!;
        public virtual DbSet<FlightBooking> FlightBookings { get; set; } = null!;
        public virtual DbSet<TicketReservation> TicketReservations { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-M4928R4;Database=WebsiteAirline;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminLogin>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.Property(e => e.AdminId)
                    .HasMaxLength(10)
                    .HasColumnName("AdminID")
                    .IsFixedLength();

                entity.Property(e => e.AdminName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<AirplaneInfo>(entity =>
            {
                entity.HasKey(e => e.PlaneId);

                entity.ToTable("AirplaneInfo");

                entity.Property(e => e.PlaneId)
                    .HasMaxLength(50)
                    .HasColumnName("PlaneID");

                entity.Property(e => e.AirplaneName).HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<FlightBooking>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.Property(e => e.BookId)
                    .HasMaxLength(20)
                    .HasColumnName("BookID");

                entity.Property(e => e.BookCusAddress).HasMaxLength(50);

                entity.Property(e => e.BookCusCnic).HasColumnName("BookCusCNIC");

                entity.Property(e => e.BookCusEmail).HasMaxLength(30);

                entity.Property(e => e.BookCusName)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.BookCusPhoneNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ReservationId)
                    .HasMaxLength(20)
                    .HasColumnName("ReservationID");
            });

            modelBuilder.Entity<TicketReservation>(entity =>
            {
                entity.HasKey(e => e.ResId);

                entity.ToTable("TicketReservation");

                entity.Property(e => e.ResId)
                    .HasMaxLength(20)
                    .HasColumnName("ResID");

                entity.Property(e => e.PlaneId)
                    .HasMaxLength(50)
                    .HasColumnName("PlaneID");

                entity.Property(e => e.ResDeptDate).HasColumnType("date");

                entity.Property(e => e.ResForm).HasMaxLength(30);

                entity.Property(e => e.ResPlaneType).HasMaxLength(10);

                entity.Property(e => e.ResTicketPrice).HasColumnType("money");

                entity.Property(e => e.ResTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID");

                entity.Property(e => e.Cnic).HasColumnName("CNIC");

                entity.Property(e => e.Email).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserName).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
