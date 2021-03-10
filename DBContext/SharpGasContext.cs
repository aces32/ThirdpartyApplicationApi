using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ThirdPartyBookingApi.Entites
{
    public partial class SharpGasContext : DbContext
    {

        public SharpGasContext(DbContextOptions<SharpGasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthCredential> AuthCredentials { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EncryptionKey> EncryptionKeys { get; set; }
        public virtual DbSet<GasInformation> GasInformations { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<ThirdPartyApplication> ThirdPartyApplications { get; set; }
        public virtual DbSet<VehicleModelInformation> VehicleModelInformation { get; set; }
        public virtual DbSet<VehicleMakeInformation> VehicleMakeInformation { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AuthCredential>(entity =>
            {
                entity.HasKey(e => e.AuthId);

                entity.Property(e => e.AuthId).HasColumnName("AuthID");

                entity.Property(e => e.ExpiryLength).HasColumnName("expiryLength");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Address 1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Address 2");

                entity.Property(e => e.Country)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(150);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EncryptionKey>(entity =>
            {
                entity.HasKey(e => e.KeyId);

                entity.Property(e => e.PrivateKeyXml).HasColumnName("PrivateKeyXML");

                entity.Property(e => e.PublicKeyXml).HasColumnName("PublicKeyXML");
            });

            modelBuilder.Entity<GasInformation>(entity =>
            {
                entity.HasKey(e => e.GasId);

                entity.ToTable("GasInformation");

                entity.HasIndex(e => e.CustomersCustomerId, "IX_GasInformation_CustomersCustomerId");

                entity.HasIndex(e => e.VendorsVendorId, "IX_GasInformation_VendorsVendorID");

                entity.Property(e => e.GasId).HasColumnName("GasID");

                entity.Property(e => e.GasMobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorsVendorId).HasColumnName("VendorsVendorID");

                entity.HasOne(d => d.CustomersCustomer)
                    .WithMany(p => p.GasInformations)
                    .HasForeignKey(d => d.CustomersCustomerId);

                entity.HasOne(d => d.VendorsVendor)
                    .WithMany(p => p.GasInformations)
                    .HasForeignKey(d => d.VendorsVendorId);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorLga)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VendorLGA");

                entity.Property(e => e.VendorMobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorState)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });



            modelBuilder.Entity<ThirdPartyApplication>(entity =>
            {
                entity.HasKey(e => e.RequestID);

            });

            modelBuilder.Entity<VehicleMakeInformation>(entity =>
            {
                entity.HasKey(e => e.VehicleMakeID);

            });

            modelBuilder.Entity<VehicleModelInformation>(entity =>
            {
                entity.HasKey(e => e.VehicleModelID);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
