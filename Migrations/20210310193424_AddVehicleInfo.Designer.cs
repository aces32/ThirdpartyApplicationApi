﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThirdPartyBookingApi.Entites;

namespace ThirdPartyBookingApi.Migrations
{
    [DbContext(typeof(SharpGasContext))]
    [Migration("20210310193424_AddVehicleInfo")]
    partial class AddVehicleInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.AuthCredential", b =>
                {
                    b.Property<int>("AuthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AuthID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExpiryLength")
                        .HasColumnType("int")
                        .HasColumnName("expiryLength");

                    b.Property<byte[]>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("varbinary(100)")
                        .HasColumnName("password");

                    b.Property<int?>("Roles")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthId");

                    b.ToTable("AuthCredentials");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Address 1");

                    b.Property<string>("Address2")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Address 2");

                    b.Property<string>("Country")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("LastName")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<byte[]>("Password")
                        .HasMaxLength(150)
                        .HasColumnType("varbinary(150)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.EncryptionKey", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrivateKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrivateKeyXml")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PrivateKeyXML");

                    b.Property<string>("PublicKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicKeyXml")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PublicKeyXML");

                    b.HasKey("KeyId");

                    b.ToTable("EncryptionKeys");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.GasInformation", b =>
                {
                    b.Property<int>("GasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GasID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Availability")
                        .HasColumnType("int");

                    b.Property<int?>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("GasImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GasMobileNumber")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<double?>("GasWeight")
                        .HasColumnType("float");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("VendorsVendorId")
                        .HasColumnType("int")
                        .HasColumnName("VendorsVendorID");

                    b.HasKey("GasId");

                    b.HasIndex(new[] { "CustomersCustomerId" }, "IX_GasInformation_CustomersCustomerId");

                    b.HasIndex(new[] { "VendorsVendorId" }, "IX_GasInformation_VendorsVendorID");

                    b.ToTable("GasInformation");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.ThirdPartyApplication", b =>
                {
                    b.Property<string>("RequestID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BodyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PremiumAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VehicleMake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleRegNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestID");

                    b.ToTable("ThirdPartyApplications");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.VehicleMakeInformation", b =>
                {
                    b.Property<int>("VehicleMakeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VehicleMake")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleMakeID");

                    b.ToTable("VehicleMakeInformation");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.VehicleModelInformation", b =>
                {
                    b.Property<string>("VehicleModelID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("VehicleMakeInformationVehicleMakeID")
                        .HasColumnType("int");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleModelID");

                    b.HasIndex("VehicleMakeInformationVehicleMakeID");

                    b.ToTable("VehicleModelInformation");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VendorID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VendorAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorLga")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("VendorLGA");

                    b.Property<string>("VendorMobileNo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("VendorPassword")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("VendorState")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("VendorType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.GasInformation", b =>
                {
                    b.HasOne("ThirdPartyBookingApi.Entites.Customer", "CustomersCustomer")
                        .WithMany("GasInformations")
                        .HasForeignKey("CustomersCustomerId");

                    b.HasOne("ThirdPartyBookingApi.Entites.Vendor", "VendorsVendor")
                        .WithMany("GasInformations")
                        .HasForeignKey("VendorsVendorId");

                    b.Navigation("CustomersCustomer");

                    b.Navigation("VendorsVendor");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.VehicleModelInformation", b =>
                {
                    b.HasOne("ThirdPartyBookingApi.Entites.VehicleMakeInformation", null)
                        .WithMany("ID")
                        .HasForeignKey("VehicleMakeInformationVehicleMakeID");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.Customer", b =>
                {
                    b.Navigation("GasInformations");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.VehicleMakeInformation", b =>
                {
                    b.Navigation("ID");
                });

            modelBuilder.Entity("ThirdPartyBookingApi.Entites.Vendor", b =>
                {
                    b.Navigation("GasInformations");
                });
#pragma warning restore 612, 618
        }
    }
}