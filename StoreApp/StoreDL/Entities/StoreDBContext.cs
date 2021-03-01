using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StoreDL.Entities
{
    public partial class StoreDBContext : DbContext
    {
        public StoreDBContext()
        {
        }

        public StoreDBContext(DbContextOptions<StoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("customerName");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("locations");

                entity.Property(e => e.LocationId).HasColumnName("locationId");

                entity.Property(e => e.LocationInventory1).HasColumnName("locationInventory1");

                entity.Property(e => e.LocationInventory2).HasColumnName("locationInventory2");

                entity.Property(e => e.LocationInventory3).HasColumnName("locationInventory3");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("locationName");

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("streetAddress");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.OrderCustomerId).HasColumnName("orderCustomerId");

                entity.Property(e => e.OrderLocationId).HasColumnName("orderLocationId");

                entity.Property(e => e.OrderQuantity1).HasColumnName("orderQuantity1");

                entity.Property(e => e.OrderQuantity2).HasColumnName("orderQuantity2");

                entity.Property(e => e.OrderQuantity3).HasColumnName("orderQuantity3");

                entity.Property(e => e.OrderTotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("orderTotal");

                entity.HasOne(d => d.OrderCustomer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orders__orderCus__2A164134");

                entity.HasOne(d => d.OrderLocation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orders__orderLoc__2B0A656D");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("products");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("productName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
