using System;
using System.Collections.Generic;
using KeyStoneEmployee_ManageMent_DataBaseLogic.DbConnect;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using KeyStoneEmployee_ManageMent_BusinessObject;

namespace KeyStoneEmployee_ManageMent_DataBaseLogic.DbConnect
{
    public partial class NagendraDBContext : DbContext
    {
        public NagendraDBContext()
        {
        }

        public NagendraDBContext(DbContextOptions<NagendraDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Dashboard> Dashboards { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<Emp12> Emp12s { get; set; } = null!;
        public virtual DbSet<Employe> Employes { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Hotel> Hotels { get; set; } = null!;
        public virtual DbSet<NewBooking> NewBookings { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<Temp> Temps { get; set; } = null!;
        public virtual DbSet<UserRegistation> UserRegistations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NORDVAN\\MSSQLSERVER01;Database=NagendraDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bookings");

                entity.Property(e => e.CustomerName)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Location)
                    .IsUnicode(false)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cities");

                entity.Property(e => e.CityName)
                    .IsUnicode(false)
                    .HasColumnName("cityName");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("countries");

                entity.Property(e => e.City)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CountryName)
                    .IsUnicode(false)
                    .HasColumnName("countryName");

                entity.Property(e => e.Customername)
                    .IsUnicode(false)
                    .HasColumnName("customername");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dashboard");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Position)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("position");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("symbol");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__departme__D877D216C4AB2589");

                entity.ToTable("department");

                entity.Property(e => e.Did)
                    .ValueGeneratedNever()
                    .HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasMaxLength(100)
                    .HasColumnName("dname");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp");

                entity.Property(e => e.Age)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("age");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Emp12>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp12");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.ToTable("Employe");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Ename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");

                entity.HasOne(d => d.DidNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Did)
                    .HasConstraintName("FK__Employee__did__625A9A57");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.ToTable("Hotel");

                entity.Property(e => e.HotelId).HasColumnName("hotelId");

                entity.Property(e => e.HotelDescription)
                    .IsUnicode(false)
                    .HasColumnName("hotelDescription");

                entity.Property(e => e.HotelImage)
                    .IsUnicode(false)
                    .HasColumnName("hotelImage");

                entity.Property(e => e.HotelLocation)
                    .IsUnicode(false)
                    .HasColumnName("hotelLocation");

                entity.Property(e => e.HotelName)
                    .IsUnicode(false)
                    .HasColumnName("hotelName");
            });

            modelBuilder.Entity<NewBooking>(entity =>
            {
                entity.ToTable("NewBooking");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.CustomerName).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patient");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Date)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<UserRegistation>(entity =>
            {
                entity.ToTable("UserRegistation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.Passwrod)
                    .IsUnicode(false)
                    .HasColumnName("passwrod");

                entity.Property(e => e.Username)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
